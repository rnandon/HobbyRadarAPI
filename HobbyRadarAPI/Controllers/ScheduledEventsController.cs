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
    // TODO: Add search by approximate location

    [Route("api/[controller]")]
    [ApiController]
    public class ScheduledEventsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ScheduledEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ScheduledEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduledEvent>>> GetScheduledEvents()
        {
            List<ScheduledEvent> allEvents = await _context.ScheduledEvents.ToListAsync();
            foreach (ScheduledEvent scheduledEvent in allEvents)
            {
                List<User> attendingUsers = _context.Users.Where(u => _context.EventAttendances.Where(ea => ea.ScheduledEventId == scheduledEvent.ScheduledEventId).Select(ea => ea.UserId).ToList().Contains(u.Id)).ToList();
                List<AttendingUserDto> attendees = new List<AttendingUserDto>();
                foreach (User user in attendingUsers)
                {
                    AttendingUserDto attendee = new AttendingUserDto() { UserFirstName = user.FirstName, UserLastInitial = user.LastName.Substring(0, 1), UserId = user.Id };
                    attendees.Add(attendee);
                }

                scheduledEvent.Attendees = attendees;

                scheduledEvent.Hobby = _context.Hobbies.Find(scheduledEvent.HobbyId);
            }

            return allEvents;
        }

        // GET: api/ScheduledEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduledEvent>> GetScheduledEvent(int id)
        {
            var scheduledEvent = await _context.ScheduledEvents.FindAsync(id);

            if (scheduledEvent == null)
            {
                return NotFound();
            }

            List<User> attendingUsers = _context.Users.Where(u => _context.EventAttendances.Where(ea => ea.ScheduledEventId == id).Select(ea => ea.UserId).ToList().Contains(u.Id)).ToList();
            List<AttendingUserDto> attendees = new List<AttendingUserDto>();
            foreach (User user in attendingUsers)
            {
                AttendingUserDto attendee = new AttendingUserDto() { UserFirstName = user.FirstName, UserLastInitial = user.LastName.Substring(0, 1), UserId = user.Id };
                attendees.Add(attendee);
            }

            scheduledEvent.Attendees = attendees;

            return scheduledEvent;
        }

        // PUT: api/ScheduledEvents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScheduledEvent(int id, ScheduledEvent scheduledEvent)
        {
            if (id != scheduledEvent.ScheduledEventId)
            {
                return BadRequest();
            }

            _context.Entry(scheduledEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScheduledEventExists(id))
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

        // POST: api/ScheduledEvents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ScheduledEvent>> PostScheduledEvent(ScheduledEventDto scheduledEventDto)
        {
            bool hobbyExists = _context.Hobbies.Any(h => h.HobbyId == scheduledEventDto.HobbyId);
            if (!hobbyExists)
            {
                return BadRequest();
            }
            ScheduledEvent scheduledEvent = MakeScheduledEvent(scheduledEventDto);
            _context.ScheduledEvents.Add(scheduledEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScheduledEvent", new { id = scheduledEvent.ScheduledEventId }, scheduledEvent);
        }

        // DELETE: api/ScheduledEvents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScheduledEvent(int id)
        {
            var scheduledEvent = await _context.ScheduledEvents.FindAsync(id);
            if (scheduledEvent == null)
            {
                return NotFound();
            }

            _context.ScheduledEvents.Remove(scheduledEvent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScheduledEventExists(int id)
        {
            return _context.ScheduledEvents.Any(e => e.ScheduledEventId == id);
        }


        public ScheduledEvent MakeScheduledEvent(ScheduledEventDto sed)
        {
            // Expects data to be validated before calling this method!!!
            DateTime validDate = new DateTime(sed.Date);
            return new ScheduledEvent() { HobbyId = sed.HobbyId, Date = validDate, Name = sed.Name, Description = sed.Description, Location = sed.Location };
        }

    }
}
