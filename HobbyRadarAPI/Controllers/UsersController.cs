using HobbyRadarAPI.Data;
using HobbyRadarAPI.DataTransferObjects;
using HobbyRadarAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            List<string> userConnectionIds = new List<string>();
            foreach (Connection connection in userConnections)
            {
                if (connection.User1Id == id)
                {
                    if (!userConnectionIds.Contains(connection.User2Id))
                    {
                        userConnectionIds.Add(connection.User2Id);
                    }
                } else if (connection.User2Id == id)
                {
                    if (!userConnectionIds.Contains(connection.User1Id))
                    {
                        userConnectionIds.Add(connection.User1Id);
                    }
                }
            }
            List<User> connectedUsers = _context.Users.Where(u => userConnectionIds.Contains(u.Id)).ToList();
            List<UserView> userViews = new List<UserView>();
            foreach (User connectedUser in connectedUsers)
            {
                List<Hobby> connectedUserHobbies = _context.Hobbies.Where(h => _context.UserHobbyRating.Where(uhr => uhr.UserId == connectedUser.Id).Select(uhr => uhr.HobbyId).ToList().Contains(h.HobbyId)).ToList();
                List<HobbyDto> connectedUserHobbyDtos = new List<HobbyDto>();
                foreach (Hobby hobby in connectedUserHobbies)
                {
                    HobbyDto currentHobby = new HobbyDto() { HobbyId = hobby.HobbyId, Name = hobby.Name, Tags = _context.Tags.Where(t => _context.HobbyTags.Where(ht => ht.HobbyId == hobby.HobbyId).Select(ht => ht.TagId).ToList().Contains(t.TagId)).Select(t => t.Name).ToList() };
                    connectedUserHobbyDtos.Add(currentHobby);
                }
                UserView userView = new UserView() { Id = connectedUser.Id, Name = $"{connectedUser.FirstName} {connectedUser.LastName}", Username = connectedUser.UserName, Hobbies = connectedUserHobbyDtos };
                userViews.Add(userView);
            }
            selectedUser.Connections = userViews;

            return Ok(selectedUser);
        }

        [HttpGet("view/{username}")]
        public IActionResult ViewUser(string username)
        {
            User user = _context.Users.Where(u => u.UserName == username).FirstOrDefault();
            if (user == null)
            {
                return BadRequest();
            }

            UserView userView = new UserView();
            userView.Name = $"{user.FirstName} {user.LastName.Substring(0, 1)}";
            userView.Username = user.UserName;
            userView.Id = user.Id;

            List<Hobby> userHobbies = _context.Hobbies.Where(h => _context.UserHobbyRating.Where(uhr => uhr.UserId == user.Id).Select(uhr => uhr.HobbyId).ToList().Contains(h.HobbyId)).ToList();
            List<HobbyDto> userHobbyDtos = new List<HobbyDto>();
            foreach (Hobby hobby in userHobbies)
            {
                userHobbyDtos.Add(new HobbyDto() { Name = hobby.Name, HobbyId = hobby.HobbyId, UserRating = 1, Tags = _context.Tags.Where(t => _context.HobbyTags.Where(ht => ht.HobbyId == hobby.HobbyId).Select(ht => ht.TagId).ToList().Contains(t.TagId)).Select(t => t.Name).ToList() }) ;
            }
            userView.Hobbies = userHobbyDtos;

            return Ok(userView);
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
        public IActionResult Put(string id, [FromBody] UserForUpdateDto user)
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
            selectedUser.UserCity = user.UserCity;
            selectedUser.UserState = user.UserState;
            selectedUser.UserZip = user.UserZip;
            _context.Users.Update(selectedUser);
            _context.SaveChanges();

            return Ok(selectedUser);
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

    public class UserView
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public List<HobbyDto> Hobbies { get; set; }
        public string Id { get; set; }
    }

    class UserWithConnections : User
    {
        public List<UserView> ConnectedUsers { get; set; }
    }
}
