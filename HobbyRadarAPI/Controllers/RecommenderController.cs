using HobbyRadarAPI.Data;
using HobbyRadarAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommenderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RecommenderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("Popular")]
        public IActionResult GetPopularHobbies()
        {
            // Assesses every hobby and gathers a total popularity score for each one.
            // Popularity score is calculated as the total of all ratings for that hobby, along with to total possible ratings and the overall rating.

            // Get all hobbies to start with.
            List<Hobby> allHobbies = _context.Hobbies.ToList();
            // Need to track three things: 
            // - Name of hobby
            // - Overall rating
            // - Total number of ratings

            // Make a new list of PopularRating objects to be able to LINQ on it later
            List<PopularRating> ratings = new List<PopularRating>();
            foreach (Hobby hobby in allHobbies)
            {
                // Get all the rating information for the current hobby
                List<int> hobbyRatings = _context.UserHobbyRating.Where(uhr => uhr.HobbyId == hobby.HobbyId).Select(uhr => uhr.Rating).ToList();
                int ratingCount = hobbyRatings.Count;
                int totalPossibleRating = ratingCount * 5; // Assuming max rating of 5
                int totalRating = hobbyRatings.Sum();
                double overallRating = Math.Round((double)(totalRating / totalPossibleRating), 1);
                // Make and add a new PopularRating to the list for sorting.
                PopularRating currentRating = new PopularRating()
                {
                    HobbyName = hobby.Name,
                    HobbyId = hobby.HobbyId,
                    OverallRating = overallRating,
                    TotalRating = totalRating,
                    TotalPossibleRating = totalPossibleRating,
                    RatingCount = ratingCount
                };
                ratings.Add(currentRating);
            }

            // Retrun ratings sorted by overall rating first, then by rating count. That way the most popular hobbies actually come first.
            return Ok(ratings.OrderBy(r => r.OverallRating).OrderBy(r => r.RatingCount));
        }

        [HttpGet("Related")]
        public IActionResult GetRelatedHobbies(string userId)
        {
            // Generates a sorted list of hobbies, scored by a tag relationship to the user's favorite hobbies.
            // Flow: Check that the user exists, then get all their hobby ratings. 
            // - For each hobby rating, get the related tags. Update the total for that tag by adding the hobby rating.
            // - After that's done, we have a list of tag rating objects, that store the tagid and total rating for every tag associated with the user's hobbies.
            // - - Assumption: tags that appear more frequently should indicate that the user likes doing hobbies with that tag.
            // - Next, get all the hobby tags that the user hasn't already rated and that are associated with a scored tag.
            // - Get a total score for the new hobby based on a total count of all the tag scores.
            // - Sort the list by score and return.

            // Check that the user exists
            bool userExists = _context.Users.Any(u => u.Id == userId);
            if (!userExists)
            {
                return BadRequest();
            }
            User user = _context.Users.Find(userId);

            // Get the user's hobby ratings
            List<UserHobbyRating> userHobbyRatings = _context.UserHobbyRating.Where(uhr => uhr.UserId == userId).ToList();

            // Start a new list of tagRatings to work with
            List<TagRating> tagRatings = new List<TagRating>();
            foreach (UserHobbyRating rating in userHobbyRatings)
            {
                // Get only the tags associated with the hobbies that the user has rated
                var relatedTags = _context.HobbyTags.Where(ht => ht.HobbyId == rating.HobbyId).ToList();
                foreach (var relatedTag in relatedTags)
                {
                    // If we have an entry for a tag, update it.
                    if (tagRatings.Exists(tr => tr.TagId == relatedTag.TagId))
                    {
                        int currentTagIndex = tagRatings.FindIndex(tr => tr.TagId == relatedTag.TagId);
                        tagRatings[currentTagIndex].Rating += rating.Rating;

                    }
                    // Otherwise, make a new entry.
                    else
                    {
                        TagRating currentTag = new TagRating() { TagId = relatedTag.TagId, Rating = rating.Rating };
                        tagRatings.Add(currentTag);
                    }
                }
            }
            // Tags now contains all the tags associated with the user's hobbies
            // TagId and Rating (total rating from all hobby ratings associated with that tag)
            // Need to find hobbies that contain the user's highest rated tags and score them.

            // Get all the hobby ids for hobbies that the user has rated.
            IEnumerable<int> userHobbyIds = userHobbyRatings.Select(uhr => uhr.HobbyId);
            // Get a list of all hobbies, excluding ones the user has already rated.
            List<Hobby> newHobbies = _context.Hobbies.Where(h => !(userHobbyIds.Contains(h.HobbyId))).ToList();
            // Make a new list of hobby ratings to track overall scores for each hobby.
            List<RelatedHobbyRating> hobbyRatings = new List<RelatedHobbyRating>();
            foreach (Hobby hobby in newHobbies)
            {
                // For every hobby, get the tags that are both associated with the current hobby and are in the list of rated tags.
                int totalHobbyScore = 0;
                List<HobbyTag> hobbyTags = _context.HobbyTags.Where(ht => (ht.HobbyId == hobby.HobbyId) && (tagRatings.Exists(tr => tr.TagId == ht.TagId))).ToList();
                foreach (HobbyTag hobbyTag in hobbyTags)
                {
                    // Update the hobby's score with the scored tag's rating
                    int relatedScore = tagRatings.Find(tr => tr.TagId == hobbyTag.TagId).Rating;
                    totalHobbyScore += relatedScore;
                }
                RelatedHobbyRating hobbyRating = new RelatedHobbyRating() { HobbyId = hobby.HobbyId, HobbyName = hobby.Name, Score = totalHobbyScore };
                hobbyRatings.Add(hobbyRating);
            }

            // Return a list of hobbies with associated scores
            return Ok(hobbyRatings.OrderBy(hr => hr.Score));
        }

        [HttpGet("People")]
        public IActionResult GetPeople(string userId)
        {
            User currentUser = _context.Users.Find(userId);
            if (currentUser == null)
            {
                return BadRequest();
            }
            // Getting ids for existing connections to exclude them from new results
            List<string> alreadyConnectedIds = _context.Users.Where(u => _context.Connections.Where(c => c.User1Id == userId).Select(c => c.User2Id).ToList().Contains(u.Id)).Select(u => u.Id).ToList();

            // People in the area that aren't already connected to the user
            List<User> localPeople = _context.Users.Where(u => u.UserZip == currentUser.UserZip && !alreadyConnectedIds.Contains(u.Id)).ToList();

            // Weighting local people based on shared hobbies
            List<int> currentUsersHobbies = _context.UserHobbyRating.Where(uhr => uhr.UserId == userId).Select(uhr => uhr.HobbyId).ToList();
            List<ConnectionRecommendation> connectionRecommendations = new List<ConnectionRecommendation>();
            foreach (User person in localPeople)
            {
                List<Hobby> personsHobbies = _context.Hobbies.Where(h => _context.UserHobbyRating.Where(uhr => uhr.UserId == person.Id).Select(uhr => uhr.HobbyId).ToList().Contains(h.HobbyId)).ToList();
                List<string> commonHobbies = personsHobbies.Where(ph => currentUsersHobbies.Contains(ph.HobbyId)).Select(ph => ph.Name).ToList();
                int rating = commonHobbies.Count;

                // Make a Dto entry for the person to help protect their security
                ConnectionRecommendation connectionRecommendation = new ConnectionRecommendation()
                {
                    FirstName = person.FirstName,
                    LastInitial = person.LastName.Substring(0, 1),
                    Id = person.Id,
                    Rating = rating,
                    Hobbies = personsHobbies.Select(ph => ph.Name).ToList(),
                    HobbiesInCommon = commonHobbies
                };
            }

            return Ok(connectionRecommendations.OrderBy(cr => cr.Rating));
        }
    }

    public class PopularRating
    {
        // Only used to track ratings of popular hobbies.
        public string HobbyName { get; set; }
        public int HobbyId { get; set; }
        public double OverallRating { get; set; }
        public int TotalRating { get; set; }
        public int TotalPossibleRating { get; set; }
        public int RatingCount { get; set; }
    }

    public class TagRating
    {
        // Used to associate tags with a rating, based on each user's preferences
        public int TagId { get; set; }
        public int Rating { get; set; }
    }

    public class RelatedHobbyRating
    {
        // Keeps track of hobbies that are associated with the user's interests
        public int HobbyId { get; set; }
        public string HobbyName { get; set; }
        public int Score { get; set; }
    }

    public class ConnectionRecommendation 
    {
        // Secure way to share pertinent info about a person
        public string FirstName { get; set; }
        public string LastInitial { get; set; }
        public string Id { get; set; }
        public int Rating { get; set; }
        public List<string> Hobbies { get; set; }
        public List<string> HobbiesInCommon { get; set; }
    }

}
