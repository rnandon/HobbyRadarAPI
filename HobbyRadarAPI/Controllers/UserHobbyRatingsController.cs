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
using Microsoft.AspNetCore.Authorization;

namespace HobbyRadarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserHobbyRatingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserHobbyRatingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserHobbyRatings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserHobbyRating>>> GetUserHobbyRating()
        {
            return await _context.UserHobbyRating.ToListAsync();
        }

        // GET: api/UserHobbyRatings?userId=123498yhdfg98y
        [HttpGet, Authorize]
        public IActionResult GetUserHobbyRatingsByUser(string userId)
        {
            bool userExists = _context.Users.Any(u => u.Id == userId);
            if (!userExists)
            {
                return BadRequest();
            }
            var userRatings = _context.UserHobbyRating.Where(uhr => uhr.UserId == userId);
            return Ok(userRatings);
        }

        // GET: api/UserHobbyRatings?userId=xc4534089rwfe&hobbyId=34
        [HttpGet]
        public IActionResult GetUserHobbyRating(string userId, int hobbyId)
        {
            var selectedUserHobbyRating = _context.UserHobbyRating.Where(uhr => uhr.UserId == userId && uhr.HobbyId == hobbyId);

            if (selectedUserHobbyRating == null)
            {
                return NotFound();
            }

            return Ok(selectedUserHobbyRating);
        }

        // PUT: api/UserHobbyRatings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutUserHobbyRating([FromBody] UserHobbyRating userHobbyRating)
        {
            if (userHobbyRating == null)
            {
                return BadRequest();
            }

            _context.Entry(userHobbyRating).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserHobbyRatingExists(userHobbyRating.UserId, userHobbyRating.HobbyId))
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

        // POST: api/UserHobbyRatings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserHobbyRating>> PostUserHobbyRating(UserHobbyRating userHobbyRating)
        {
            _context.UserHobbyRating.Add(userHobbyRating);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserHobbyRatingExists(userHobbyRating.UserId, userHobbyRating.HobbyId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserHobbyRating", new { id = userHobbyRating.UserId }, userHobbyRating);
        }

        // DELETE: api/UserHobbyRatings?userId=xc4534089rwfe&hobbyId=34
        [HttpDelete]
        public async Task<IActionResult> DeleteUserHobbyRating(string userId, int hobbyId)
        {
            var selectedUserHobbyRating = _context.UserHobbyRating.Where(uhr => uhr.UserId == userId && uhr.HobbyId == hobbyId).FirstOrDefault();

            if (selectedUserHobbyRating == null)
            {
                return NotFound();
            }

            _context.UserHobbyRating.Remove(selectedUserHobbyRating);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserHobbyRatingExists(string userId, int hobbyId)
        {
            return _context.UserHobbyRating.Any(e => e.UserId == userId && e.HobbyId == hobbyId);
        }
    }
}
