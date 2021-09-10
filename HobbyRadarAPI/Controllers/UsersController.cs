using HobbyRadarAPI.Data;
using HobbyRadarAPI.DataTransferObjects;
using HobbyRadarAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HobbyRadarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<UsersController>
        [HttpGet, Authorize(Roles = "Admin")]
        public IEnumerable<User> Get()
        {
            return _context.Users;
        }

        // GET api/<UsersController>/xcv908utkljvhb78
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            User selectedUser = _context.Users.Find(id);
            if (selectedUser == null)
            {
                return NotFound();
            }

            return Ok(selectedUser);
        }

        // PUT api/<UsersController>/njw345t89yhv
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] UserDto user)
        {
            User selectedUser = _context.Users.Find(id);
            if (selectedUser == null)
            {
                return NotFound();
            }
            selectedUser.FirstName = user.FirstName;
            selectedUser.LastName = user.LastName;
            selectedUser.UserName = user.UserName;
            selectedUser.Email = user.Email;
            selectedUser.PhoneNumber = user.PhoneNumber;
            _context.Users.Update(selectedUser);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<UsersController>/08ibhnj90
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            User selectedUser = _context.Users.Find(id);
            if (selectedUser == null)
            {
                return NotFound();
            }
            _context.Users.Remove(selectedUser);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
