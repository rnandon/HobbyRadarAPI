using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HobbyRadarAPI.Data;
using HobbyRadarAPI.Models;
using HobbyRadarAPI.DataTransferObjects;

namespace HobbyRadarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HobbiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HobbiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Hobbies
        [HttpGet]
        public async Task<ActionResult<List<HobbyDto>>> GetHobbies()
        {
            var rawHobbies = await _context.Hobbies.ToListAsync();
            List<HobbyDto> output = new List<HobbyDto>();
            foreach (Hobby hobby in rawHobbies)
            {

                List<string> tagNames = _context.Tags.Where(t => _context.HobbyTags.Where(ht => ht.HobbyId == hobby.HobbyId).Select(ht => ht.TagId).ToList().Contains(t.TagId)).Select(t => t.Name).ToList();

                HobbyDto currentHobby = new HobbyDto() { Name = hobby.Name, HobbyId = hobby.HobbyId, Tags = tagNames };
                output.Add(currentHobby);
            }

            return output;
        }

        // GET: api/Hobbies/5
        [HttpGet("{id}")]
        public IActionResult GetHobby(int id)
        {
            Hobby hobby = _context.Hobbies.Where(h => h.HobbyId == id).FirstOrDefault();
                
            if (hobby == null)
            {
                return NotFound();
            }
            List<string> hobbyTags = _context.Tags.Where(t => _context.HobbyTags.Where(ht => ht.HobbyId == hobby.HobbyId).Select(ht => ht.TagId).ToList().Contains(t.TagId)).Select(t => t.Name).ToList();
            HobbyDto output = new HobbyDto() { HobbyId = hobby.HobbyId, Name = hobby.Name, Tags = hobbyTags };

            return Ok(output);
        }

        // GET: api/Hobbies/byTag/tagId
        [HttpGet("byTag/{tagId}")]
        public IActionResult GetHobbiesByTag(int tagId)
        {
            // Make sure the tagId provided is valid
            bool tagExists = _context.Tags.Any(t => t.TagId == tagId);
            if (!tagExists)
            {
                return BadRequest();
            }

            // If tagId is valid, get the hobbies that contain that tag and create a new HobbyDto object from the hobby
            List<HobbyDto> output = new List<HobbyDto>();
            List<Hobby> relevantHobbies = _context.Hobbies.Where(h => _context.HobbyTags.Where(ht => ht.TagId == tagId).Select(ht => ht.HobbyId).ToList().Contains(h.HobbyId)).ToList();
            foreach (Hobby hobby in relevantHobbies)
            {
                List<string> relatedTagNames = _context.Tags.Where(t => _context.HobbyTags.Where(ht => ht.HobbyId == hobby.HobbyId).Select(ht => ht.TagId).ToList().Contains(t.TagId)).Select(t => t.Name).ToList();
                HobbyDto currentHobby = new HobbyDto() { Name = hobby.Name, HobbyId = hobby.HobbyId, Tags = relatedTagNames };
                output.Add(currentHobby);
            }
            return Ok(output);
        }

        // PUT: api/Hobbies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHobby(int id, Hobby hobby)
        {
            // HobbyDto has tag associations built in, need to address this

            if (id != hobby.HobbyId)
            {
                return BadRequest();
            }

            _context.Entry(hobby).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HobbyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Hobbies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hobby>> PostHobby(HobbyDto hobby)
        {
            Hobby incomingHobby = new Hobby() { Name = hobby.Name };
            _context.Hobbies.Add(incomingHobby);
            await _context.SaveChangesAsync();

            List<Tag> tagsToAssociate = new List<Tag>();

            foreach (string tag in hobby.Tags)
            {
                Tag associatedTag = _context.Tags.Find(tag);
                if (associatedTag == null)
                {
                    // Make a new tag entry
                    Tag newTag = new Tag() { Name = tag };
                    tagsToAssociate.Add(newTag);
                }
                else
                {
                    tagsToAssociate.Add(associatedTag);
                }
            }

            // Need to retrieve the hobby from the db to get the id
            Hobby addedHobby = _context.Hobbies.Where(h => h.Name == hobby.Name).FirstOrDefault();
            // Make new Hobby-Tag associations
            foreach (Tag tagToAssociate in tagsToAssociate)
            {
                HobbyTag newHobbyTag = new HobbyTag() { HobbyId = addedHobby.HobbyId, TagId = tagToAssociate.TagId };
                _context.HobbyTags.Add(newHobbyTag);
            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHobby", new { id = hobby.HobbyId }, hobby);
        }

        // DELETE: api/Hobbies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHobby(int id)
        {
            var hobby = await _context.Hobbies.FindAsync(id);
            if (hobby == null)
            {
                return NotFound();
            }

            _context.Hobbies.Remove(hobby);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HobbyExists(int id)
        {
            return _context.Hobbies.Any(e => e.HobbyId == id);
        }
    }
}
