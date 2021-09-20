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
        [HttpGet]
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

            List<Hobby> userHobbies = _context.Hobbies.Where(h => _context.UserHobbyRating.Where(uhr => uhr.UserId == id).Select(uhr => uhr.HobbyId).ToList().Contains(h.HobbyId)).ToList();
            List<HobbyDto> userHobbyList = new List<HobbyDto>();
            foreach (Hobby hobby in userHobbies)
            {
                string name = hobby.Name;
                int hobbyId = hobby.HobbyId;
                int rating = _context.UserHobbyRating.Where(uhr => (uhr.HobbyId == hobbyId && uhr.UserId == id)).FirstOrDefault().Rating;
                List<string> hobbyTags = _context.Tags.Where(t => _context.HobbyTags.Where(ht => ht.HobbyId == hobbyId).Select(ht => ht.TagId).ToList().Contains(t.TagId)).Select(t => t.Name).ToList();
                HobbyDto userHobby = new HobbyDto() { HobbyId = hobbyId, Name = name, Tags = hobbyTags, UserRating = rating};
                userHobbyList.Add(userHobby);
            }
            selectedUser.UserHobbies = userHobbyList;

            List<ConnectionInvite> invitesReceived = _context.ConnectionInvites.Where(ci => ci.ToUserId == id).ToList();
            List<ConnectionInvite> invitesSent = _context.ConnectionInvites.Where(ci => ci.FromUserId == id).ToList();
            selectedUser.InvitesReceived = invitesReceived;
            selectedUser.InvitesSent = invitesSent;

            List<UserAlert> userAlerts = _context.UserAlerts.Where(ua => ua.UserId == id).ToList();
            selectedUser.Alerts = userAlerts;

            List<ScheduledEvent> attendingEvents = _context.ScheduledEvents.Where(se => _context.EventAttendances.Where(ea => ea.UserId == id).Select(ea => ea.ScheduledEventId).ToList().Contains(se.ScheduledEventId)).ToList();
            selectedUser.AttendingEvents = attendingEvents;

            List<Connection> userConnections = _context.Connections.Where(c => (c.User1Id == id || c.User2Id == id)).ToList();
            selectedUser.Connections = userConnections;

            return Ok(selectedUser);
        }

        // PUT api/Users/uhr
        [HttpPut("uhr")]
        public IActionResult UpdateUserHobbyRating([FromBody] UserHobbyRating userHobbyRating)
        {
            User selectedUser = _context.Users.Find(userHobbyRating.UserId);
            if (selectedUser == null)
            {
                return NotFound();
            }
            UserHobbyRating recordToUpdate = _context.UserHobbyRating.Where(uhr => uhr.HobbyId == userHobbyRating.HobbyId && uhr.UserId == userHobbyRating.UserId).FirstOrDefault();
            recordToUpdate.Rating = userHobbyRating.Rating;
            _context.UserHobbyRating.Update(recordToUpdate);
            _context.SaveChanges();


            return Get(userHobbyRating.UserId);
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
            selectedUser.ContactPreference = user.ContactPreference;
            _context.Users.Update(selectedUser);
            _context.SaveChanges();

            return Ok();
        }

        // PUT api/<UsersController>/uhr
        [HttpPost("uhr")]
        public IActionResult AddUserHobbyRating([FromBody] UserHobbyRating userHobbyRating)
        {
            User selectedUser = _context.Users.Find(userHobbyRating.UserId);
            if (selectedUser == null)
            {
                return NotFound();
            }
            _context.UserHobbyRating.Add(userHobbyRating);
            _context.SaveChanges();

            return Get(userHobbyRating.UserId);
        }

        // PUT api/<UsersController>/event
        [HttpPost("event")]
        public IActionResult AddEventAttendance([FromBody] EventAttendance eventAttendance)
        {
            User selectedUser = _context.Users.Find(eventAttendance.UserId);
            if (selectedUser == null)
            {
                return NotFound();
            }
            _context.EventAttendances.Add(eventAttendance);
            _context.SaveChanges();

            return Get(eventAttendance.UserId);
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
