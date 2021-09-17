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
    public class EventAttendancesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventAttendancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EventAttendances
        [HttpGet, Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<EventAttendance>>> GetEventAttendances()
        {
            return await _context.EventAttendances.ToListAsync();
        }

        // GET: api/EventAttendances?eventId=234&userId=23490-85yhs0p9df8y4
        [HttpGet]
        public IActionResult GetEventAttendance(int eventId, string userId)
        {
            var eventAttendance = _context.EventAttendances.Where(ea => ea.ScheduledEventId == eventId && ea.UserId == userId);

            if (eventAttendance == null)
            {
                return NotFound();
            }

            return Ok(eventAttendance);
        }

        // GET: api/EventAttendances/user/{id}
        [HttpGet("user/{id}")]
        public IActionResult GetAttendanceByUser(string id)
        {
            bool userExists = _context.Users.Any(u => u.Id == id);
            if (!userExists)
            {
                return NotFound();
            }
            List<EventAttendance> attendances = _context.EventAttendances.Where(ea => ea.UserId == id).ToList();
            return Ok(attendances);
        }

        // GET: api/EventAttendances/event/{id}
        [HttpGet("event/{id}")]
        public IActionResult GetAttendanceByEvent(int id)
        {
            bool eventExists = _context.ScheduledEvents.Any(se => se.ScheduledEventId == id);
            if (!eventExists)
            {
                return NotFound();
            }
            List<EventAttendance> attendances = _context.EventAttendances.Where(ea => ea.ScheduledEventId == id).ToList();
            return Ok(attendances);
        }

        // PUT: api/EventAttendances?eventId=234&userId=23490-85yhs0p9df8y4
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutEventAttendance(int eventId, string userId, [FromBody] EventAttendance eventAttendance)
        {
            bool eventExists = _context.ScheduledEvents.Any(se => se.ScheduledEventId == eventId);
            bool userExists = _context.Users.Any(u => u.Id == userId);

            if (!eventExists || !userExists)
            {
                return BadRequest();
            }

            _context.Entry(eventAttendance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventAttendanceExists(eventAttendance.ScheduledEventId, eventAttendance.UserId))
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

        // POST: api/EventAttendances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EventAttendance>> PostEventAttendance(EventAttendance eventAttendance)
        {
            _context.EventAttendances.Add(eventAttendance);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EventAttendanceExists(eventAttendance.ScheduledEventId, eventAttendance.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEventAttendance", new { id = eventAttendance.ScheduledEventId }, eventAttendance);
        }

        // DELETE: api/EventAttendances/5
        [HttpDelete]
        public IActionResult DeleteEventAttendance(int eventId, string userId)
        {
            var eventAttendance = _context.EventAttendances.Where(ea => ea.ScheduledEventId == eventId && ea.UserId == userId).FirstOrDefault();
            if (eventAttendance == null)
            {
                return NotFound();
            }

            _context.EventAttendances.Remove(eventAttendance);
            _context.SaveChanges();

            return NoContent();
        }

        private bool EventAttendanceExists(int eventId, string userId)
        {
            return _context.EventAttendances.Any(e => e.ScheduledEventId == eventId && e.UserId == userId);
        }
    }
}
