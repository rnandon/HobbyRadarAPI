using HobbyRadarAPI.DataTransferObjects;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HobbyRadarAPI.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public string UserZip { get; set; }
        public string ContactPreference { get; set; }

        [NotMapped]
        public List<HobbyDto> UserHobbies { get; set; }
        [NotMapped]
        public List<ConnectionInvite> InvitesReceived { get; set; }
        [NotMapped]
        public List<ConnectionInvite> InvitesSent { get; set; }
        [NotMapped]
        public List<UserAlert> Alerts { get; set; }
        [NotMapped]
        public List<ScheduledEvent> AttendingEvents { get; set; }
        [NotMapped]
        public List<Connection> Connections { get; set; }
    }
}
