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
    public class ConnectionInvitesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConnectionInvitesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ConnectionInvites
        [HttpGet, Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<ConnectionInvite>>> GetConnectionInvites()
        {
            return await _context.ConnectionInvites.ToListAsync();
        }

        // GET: api/ConnectionInvites/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConnectionInvite>> GetConnectionInvite(int id)
        {
            var connectionInvite = await _context.ConnectionInvites.FindAsync(id);

            if (connectionInvite == null)
            {
                return NotFound();
            }

            return connectionInvite;
        }

        // GET: api/ConnectionInvites/from/id
        [HttpGet("/from/{id}")]
        public IActionResult GetConnectionInvitesBySender(string id)
        {
            bool userExists = _context.Users.Any(u => u.Id == id);
            if (!userExists)
            {
                return BadRequest();
            }
            List<ConnectionInvite> invitesBySender = _context.ConnectionInvites.Where(ci => ci.FromUserId == id).ToList();
            return Ok(invitesBySender);
        }

        // GET: api/ConnectionInvites/from/id
        [HttpGet("/to/{id}")]
        public IActionResult GetConnectionInvitesByRecipient(string id)
        {
            bool userExists = _context.Users.Any(u => u.Id == id);
            if (!userExists)
            {
                return BadRequest();
            }
            List<ConnectionInvite> invitesByRecipient = _context.ConnectionInvites.Where(ci => ci.ToUserId == id).ToList();
            return Ok(invitesByRecipient);
        }

        // PUT: api/ConnectionInvites/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConnectionInvite(int id, ConnectionInvite connectionInvite)
        {
            if (id != connectionInvite.ConnectionInviteId)
            {
                return BadRequest();
            }

            _context.Entry(connectionInvite).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConnectionInviteExists(id))
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

        // PUT: api/ConnectionInvites/accept/5
        [HttpPut("/accept/{id}")]
        public IActionResult AcceptConnectionInvite(int id)
        {
            if (!ConnectionInviteExists(id))
            {
                return NotFound();
            }
            ConnectionInvite invite = _context.ConnectionInvites.Find(id);
            invite.Accepted = true;
            _context.ConnectionInvites.Update(invite);
            _context.SaveChanges();
            return Ok();
        }

        // PUT: api/ConnectionInvites/dismiss/5
        [HttpPut("/dismiss/{id}")]
        public IActionResult DismissConnectionInvite(int id)
        {
            if (!ConnectionInviteExists(id))
            {
                return NotFound();
            }
            ConnectionInvite invite = _context.ConnectionInvites.Find(id);
            invite.Dismissed = true;
            _context.ConnectionInvites.Update(invite);
            _context.SaveChanges();
            return Ok();
        }

        // POST: api/ConnectionInvites
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConnectionInvite>> PostConnectionInvite(ConnectionInvite connectionInvite)
        {
            _context.ConnectionInvites.Add(connectionInvite);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConnectionInvite", new { id = connectionInvite.ConnectionInviteId }, connectionInvite);
        }

        // DELETE: api/ConnectionInvites/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConnectionInvite(int id)
        {
            var connectionInvite = await _context.ConnectionInvites.FindAsync(id);
            if (connectionInvite == null)
            {
                return NotFound();
            }

            _context.ConnectionInvites.Remove(connectionInvite);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConnectionInviteExists(int id)
        {
            return _context.ConnectionInvites.Any(e => e.ConnectionInviteId == id);
        }
    }
}
