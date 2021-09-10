using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HobbyRadarAPI.Data;
using HobbyRadarAPI.Models;

namespace HobbyRadarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HobbyTagsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HobbyTagsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/HobbyTags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HobbyTag>>> GetHobbyTags()
        {
            return await _context.HobbyTags.ToListAsync();
        }

        // GET: api/HobbyTags?hobbyId=123&tagId=23
        [HttpGet]
        public IActionResult GetHobbyTag(int hobbyId, int tagId)
        {
            HobbyTag hobbyTag = _context.HobbyTags.Where(ht => ht.HobbyId == hobbyId && ht.TagId == tagId).FirstOrDefault();

            if (hobbyTag == null)
            {
                return NotFound();
            }

            return Ok(hobbyTag);
        }

        // PUT: api/HobbyTags/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutHobbyTag(int hobbyId, int tagId, [FromBody] HobbyTag hobbyTag)
        {
            bool hobbyExists = _context.Hobbies.Any(h => h.HobbyId == hobbyId);
            bool tagExists = _context.Tags.Any(t => t.TagId == tagId);

            if (!hobbyExists || !tagExists)
            {
                return BadRequest();
            }

            _context.Entry(hobbyTag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HobbyTagExists(hobbyId, tagId))
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

        // POST: api/HobbyTags
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HobbyTag>> PostHobbyTag(HobbyTag hobbyTag)
        {
            _context.HobbyTags.Add(hobbyTag);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HobbyTagExists(hobbyTag.HobbyId, hobbyTag.TagId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHobbyTag", new { id = hobbyTag.HobbyId }, hobbyTag);
        }

        // DELETE: api/HobbyTags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHobbyTag(int hobbyId, int tagId)
        {
            var hobbyTag = await _context.HobbyTags.Where(ht => ht.HobbyId == hobbyId && ht.TagId == tagId).FirstOrDefaultAsync();
            if (hobbyTag == null)
            {
                return NotFound();
            }

            _context.HobbyTags.Remove(hobbyTag);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HobbyTagExists(int hobbyId, int tagId)
        {
            return _context.HobbyTags.Any(e => e.HobbyId == hobbyId && e.TagId == tagId);
        }
    }
}
