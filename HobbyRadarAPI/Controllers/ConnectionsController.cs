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
    public class ConnectionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConnectionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Connections
        [HttpGet, Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Connection>>> GetConnections()
        {
            return await _context.Connections.ToListAsync();
        }

        // GET: api/Connections?user1Id=12345r9p80y2&user2Id=q2345lriuyfv9p83y4 
        [HttpGet]
        public IActionResult GetConnection(string user1Id, string user2Id)
        {
            bool user1Exists = _context.Users.Any(u => u.Id == user1Id);
            bool user2Exists = _context.Users.Any(u => u.Id == user2Id);

            if (!user1Exists || !user2Exists)
            {
                return BadRequest();
            }

            Connection connection = _context.Connections.Where(c => c.User1Id == user1Id && c.User2Id == user2Id).FirstOrDefault();

            if (connection == null)
            {
                return NotFound();
            }

            return Ok(connection);
        }

        // GET: api/Connections/user/{id}
        [HttpGet("user/{id}")]
        public IActionResult GetConnectionsByUser(string id)
        {
            bool userExists = _context.Users.Any(u => u.Id == id);
            if (!userExists)
            {
                return BadRequest();
            }
            List<Connection> connectionsByUser = _context.Connections.Where(c => c.User1Id == id).ToList();
            return Ok(connectionsByUser);
        }

        // PUT: api/Connections/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754D
        [HttpPut]
        public async Task<IActionResult> PutConnection(string user1Id, string user2Id, [FromBody] Connection connection)
        {
            bool user1Exists = _context.Users.Any(u => u.Id == user1Id);
            bool user2Exists = _context.Users.Any(u => u.Id == user2Id);

            if (!user1Exists || !user2Exists)
            {
                return BadRequest();
            }

            _context.Entry(connection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConnectionExists(user1Id, user2Id))
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

        // POST: api/Connections
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Connection>> PostConnection(Connection connection)
        {
            _context.Connections.Add(connection);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ConnectionExists(connection.User1Id, connection.User2Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetConnection", new { id = connection.User1Id }, connection);
        }

        // DELETE: api/Connections?user1Id=2349ihn48&user2Id=34iounv90834y
        [HttpDelete]
        public async Task<IActionResult> DeleteConnection(string user1Id, string user2Id)
        {
            bool user1Exists = _context.Users.Any(u => u.Id == user1Id);
            bool user2Exists = _context.Users.Any(u => u.Id == user2Id);

            if (!user1Exists || !user2Exists)
            {
                return BadRequest();
            }

            Connection connection = _context.Connections.Where(c => c.User1Id == user1Id && c.User2Id == user2Id).FirstOrDefault();

            _context.Connections.Remove(connection);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConnectionExists(string user1Id, string user2Id)
        {
            return _context.Connections.Any(c => c.User1Id == user1Id && c.User2Id == user2Id);
        }
    }
}
