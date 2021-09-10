﻿using System;
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
            return await _context.ScheduledEvents.ToListAsync();
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
        public async Task<ActionResult<ScheduledEvent>> PostScheduledEvent(ScheduledEvent scheduledEvent)
        {
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
    }
}
