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
        public List<PopularRating> GetPopularHobbies()
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
                hobbyRatings = PurgeZeroValues(hobbyRatings);
                int ratingCount = hobbyRatings.Count;
                double totalPossibleRating = ratingCount * 5; // Assuming max rating of 5
                double totalRating = hobbyRatings.Sum();
                double overallRating = totalPossibleRating == 0? 0 : Math.Round((double)(totalRating / totalPossibleRating) * 5, 2);

                if (totalRating != 0)
                {
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
            }

            // Retrun ratings sorted by overall rating first, then by rating count. That way the most popular hobbies actually come first.
            return ratings.OrderByDescending(r => r.OverallRating).ToList();
        }

        [HttpGet("Related")]
        public List<RelatedHobbyRating> GetRelatedHobbies(string userId)
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
                List<HobbyTag> hobbyTags = _context.HobbyTags.Where(ht => (ht.HobbyId == hobby.HobbyId) && (tagRatings.Select(tr => tr.TagId).ToList().Contains(ht.TagId))).ToList();
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
            return hobbyRatings.OrderByDescending(hr => hr.Score).ToList();
        }

        [HttpGet("People")]
        public List<ConnectionRecommendation> GetPeople(string userId)
        {
            User currentUser = _context.Users.Find(userId);
            // Getting ids for existing connections to exclude them from new results
            List<string> alreadyConnectedIds = _context.Users.Where(u => _context.Connections.Where(c => c.User1Id == userId).Select(c => c.User2Id).ToList().Contains(u.Id)).Select(u => u.Id).ToList();

            // People in the area that aren't already connected to the user
            List<User> localPeople = _context.Users.Where(u => u.UserZip == currentUser.UserZip && !alreadyConnectedIds.Contains(u.Id) && u.Id != currentUser.Id).ToList();

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
                    Username = person.UserName,
                    Rating = rating,
                    Hobbies = personsHobbies.Select(ph => ph.Name).ToList(),
                    HobbiesInCommon = commonHobbies
                };

                connectionRecommendations.Add(connectionRecommendation);
            }

            return connectionRecommendations.OrderByDescending(cr => cr.Rating).ToList();
        }

        [HttpGet("LocallyPopular")]
        public List<PopularRating> GetLocallyPopularHobbies(string userId)
        {
            // This method is *almost* identical to GetPopularHobbies.
            // The only difference is that instead of curating ratings for all hobbies, this one is filtered by the user's zipcode.

            User user = _context.Users.Find(userId);
            List<string> localUserIds = _context.Users.Where(u => u.UserZip == user.UserZip).Select(u => u.Id).ToList();

            // Just get hobbies that users in the given user's zip code are following.
            List<Hobby> localHobbies = _context.Hobbies.Where(h => _context.UserHobbyRating.Where(uhr => localUserIds.Contains(uhr.UserId)).Select(uhr => uhr.HobbyId).ToList().Contains(h.HobbyId)).ToList();

            List<PopularRating> ratings = new List<PopularRating>();
            foreach (Hobby hobby in localHobbies)
            {
                // Get all the rating information for the current hobby
                List<int> hobbyRatings = _context.UserHobbyRating.Where(uhr => uhr.HobbyId == hobby.HobbyId && localUserIds.Contains(uhr.UserId)).Select(uhr => uhr.Rating).ToList();
                hobbyRatings = PurgeZeroValues(hobbyRatings);
                int ratingCount = hobbyRatings.Count;
                double totalPossibleRating = ratingCount * 5; // Assuming max rating of 5
                double totalRating = hobbyRatings.Sum();
                double overallRating = totalPossibleRating == 0 ? 0 : Math.Round((double)(totalRating / totalPossibleRating) * 5, 2);
                if (totalRating != 0)
                {
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
            }

            // Retrun ratings sorted by overall rating first, then by rating count. That way the most popular hobbies actually come first.
            return ratings.OrderByDescending(r => r.OverallRating).ToList();

        }

        [HttpGet]
        public IActionResult GetRecommendations(string pop, string rel, string peo, string loc, string userId)
        {
            AllRecommendations recommendations = new AllRecommendations();
            bool userExists = _context.Users.Any(u => u.Id == userId);

            if (pop == "y")
            {
                var popular = GetPopularHobbies();
                recommendations.PopularHobbies = popular;
            }
            if (userExists && rel == "y")
            {
                var relatedHobbies = GetRelatedHobbies(userId);
                recommendations.RelatedHobbies = relatedHobbies;
            }
            if (userExists && peo == "y")
            {
                var people = GetPeople(userId);
                recommendations.PossibleConnections = people;
            }
            if (userExists && loc == "y")
            {
                var locallyPopular = GetLocallyPopularHobbies(userId);
                recommendations.LocallyPopularHobbies = locallyPopular;
            }

            return Ok(recommendations);
        }

        [HttpGet("related/{hobbyId}")]
        public IActionResult GetRelatedHobbies(int hobbyId)
        {
            bool hobbyExists = _context.Hobbies.Any(h => h.HobbyId == hobbyId);
            if (!hobbyExists)
            {
                return BadRequest();
            }

            List<int> hobbyTags = _context.Tags.Where(t => _context.HobbyTags.Where(ht => ht.HobbyId == hobbyId).Select(ht => ht.TagId).ToList().Contains(t.TagId)).Select(t => t.TagId).ToList();
            List<Hobby> allHobbies = _context.Hobbies.Where(h => h.HobbyId != hobbyId).ToList();

            List<RelatedHobbyRating> relatedHobbies = new List<RelatedHobbyRating>();
            foreach (Hobby hobby in allHobbies)
            {
                List<int> associatedTagIds = _context.Tags.Where(t => _context.HobbyTags.Where(ht => ht.HobbyId == hobby.HobbyId).Select(ht => ht.TagId).ToList().Contains(t.TagId)).Select(t => t.TagId).ToList();
                RelatedHobbyRating currentHobbyRating = new RelatedHobbyRating() { HobbyId = hobby.HobbyId, HobbyName = hobby.Name, Score = 0 };
                foreach (int ati in associatedTagIds)
                {
                    if (hobbyTags.Contains(ati))
                    {
                        currentHobbyRating.Score++;
                    }
                }
                relatedHobbies.Add(currentHobbyRating);
            }

            return Ok(relatedHobbies.OrderByDescending(rh => rh.Score));
        }

        public List<int> PurgeZeroValues(List<int> list)
        {
            List<int> output = new List<int>();
            foreach (int item in list)
            {
                if (item != 0)
                {
                    output.Add(item);
                }
            }
            return output;
        }
    }

    public class AllRecommendations
    {
        public List<PopularRating> PopularHobbies { get; set; }
        public List<RelatedHobbyRating> RelatedHobbies { get; set; }
        public List<ConnectionRecommendation> PossibleConnections { get; set; }
        public List<PopularRating> LocallyPopularHobbies { get; set; }
    }

    public class PopularRating
    {
        // Only used to track ratings of popular hobbies.
        public string HobbyName { get; set; }
        public int HobbyId { get; set; }
        public double OverallRating { get; set; }
        public double TotalRating { get; set; }
        public double TotalPossibleRating { get; set; }
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
        public string Username { get; set; }
        public int Rating { get; set; }
        public List<string> Hobbies { get; set; }
        public List<string> HobbiesInCommon { get; set; }
    }

}
