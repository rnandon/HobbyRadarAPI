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
using HobbyRadarAPI.DataTransferObjects;

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
        [HttpGet("from/{id}")]
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

        // GET: api/ConnectionInvites/to/id
        [HttpGet("to/{id}")]
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

        // GET: api/ConnectionInvites/to/id/users
        [HttpGet("to/{id}/users")]
        public IActionResult GetUsersByConnectionInvitesToRecipient(string id)
        {
            bool userExists = _context.Users.Any(u => u.Id == id);
            if (!userExists)
            {
                return BadRequest();
            }
            List<UserView> userViews = new List<UserView>();
            List<string> userIds = _context.ConnectionInvites.Where(ci => ci.ToUserId == id).Select(ci => ci.FromUserId).ToList();
            foreach (string userId in userIds)
            {
                User fromUser = _context.Users.Find(userId);
                UserView currentUser = new UserView() { Id = userId, Name = $"{ fromUser.FirstName } { fromUser.LastName.Substring(0, 1) }", Username = fromUser.UserName };
                userViews.Add(currentUser);
            }

            return Ok(userViews);
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
        [HttpPut("accept/{id}")]
        public IActionResult AcceptConnectionInvite(int id)
        {
            if (!ConnectionInviteExists(id))
            {
                return NotFound();
            }
            ConnectionInvite invite = _context.ConnectionInvites.Find(id);
            invite.Accepted = true;
            invite.Dismissed = true;
            _context.ConnectionInvites.Update(invite);

            Connection connection = new Connection() { User1Id = invite.FromUserId, User2Id = invite.ToUserId };
            _context.Connections.Add(connection);

            _context.SaveChanges();
            return Ok();
        }

        // PUT: api/ConnectionInvites/dismiss/5
        [HttpPut("dismiss/{id}")]
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
        public IActionResult PostConnectionInvite(ConnectionInviteDto ci)
        {
            bool fromUserExists = _context.Users.Any(u => u.Id == ci.FromUserId);
            bool toUserExists = _context.Users.Any(u => u.Id == ci.ToUserId);
            ConnectionInvite connectionInvite = new ConnectionInvite() { FromUserId = ci.FromUserId, ToUserId = ci.ToUserId, Accepted = ci.Accepted == "true" ? true : false, Dismissed = ci.Dismissed == "true" ? true : false, Message = ci.Message, DateSent = new DateTime(ci.DateSent) };

            _context.ConnectionInvites.Add(connectionInvite);
            _context.SaveChanges();

            connectionInvite = _context.ConnectionInvites.Where(i => i.FromUserId == ci.FromUserId && i.ToUserId == ci.ToUserId).FirstOrDefault();

            return Ok(connectionInvite);
            var body = Request.Body;
            return Ok();
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
