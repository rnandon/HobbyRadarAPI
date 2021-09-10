using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HobbyRadarAPI.Data;
using HobbyRadarAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace HobbyRadarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAlertsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserAlertsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserAlerts
        [HttpGet, Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<UserAlert>>> GetUserAlerts()
        {
            return await _context.UserAlerts.ToListAsync();
        }

        // GET: api/UserAlerts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserAlert>> GetUserAlert(int id)
        {
            var userAlert = await _context.UserAlerts.FindAsync(id);

            if (userAlert == null)
            {
                return NotFound();
            }

            return userAlert;
        }

        // GET: api/UserAlerts/User/{id}
        [HttpGet("/User/{id}")]
        public IActionResult GetAlertsByUser(string id)
        {
            bool userExists = _context.Users.Any(u => u.Id == id);
            if (!userExists)
            {
                return BadRequest();
            }
            List<UserAlert> alertsForUser = _context.UserAlerts.Where(ua => ua.UserId == id).ToList();
            return Ok(alertsForUser);
        }

        // PUT: api/UserAlerts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserAlert(int id, [FromBody] UserAlert userAlert)
        {
            if (id != userAlert.UserAlertId)
            {
                return BadRequest();
            }

            _context.Entry(userAlert).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserAlertExists(id))
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

        // PUT: api/UserAlerts/dismiss/id
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("dismiss/{id}")]
        public IActionResult DismissUserAlert(int id)
        {
            if (!UserAlertExists(id))
            {
                return NotFound();
            }
            UserAlert userAlert = _context.UserAlerts.Find(id);
            userAlert.Dismissed = true;
            _context.UserAlerts.Update(userAlert);
            _context.SaveChanges();
            return Ok();
        }

        // POST: api/UserAlerts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserAlert>> PostUserAlert([FromBody] UserAlert userAlert)
        {
            _context.UserAlerts.Add(userAlert);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserAlert", new { id = userAlert.UserAlertId }, userAlert);
        }

        // DELETE: api/UserAlerts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserAlert(int id)
        {
            var userAlert = await _context.UserAlerts.FindAsync(id);
            if (userAlert == null)
            {
                return NotFound();
            }

            _context.UserAlerts.Remove(userAlert);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserAlertExists(int id)
        {
            return _context.UserAlerts.Any(e => e.UserAlertId == id);
        }
    }
}
