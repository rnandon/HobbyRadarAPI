using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HobbyRadarAPI.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [InverseProperty("User")]
        public List<UserHobbyRating> UserHobbies { get; set; }
        [InverseProperty("ToUser")]
        public List<ConnectionInvite> InvitesReceived { get; set; }
        [InverseProperty("FromUser")]
        public List<ConnectionInvite> InvitesSent { get; set; }
        [InverseProperty("User")]
        public List<UserAlert> Alerts { get; set; }
        [InverseProperty("User")]
        public List<EventAttendance> AttendingEvents { get; set; }
        [InverseProperty("User1")]
        public List<Connection> Connections { get; set; }
    }
}
