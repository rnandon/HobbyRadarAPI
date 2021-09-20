using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Models
{
    public class ExternalInvitation
    {
        public int ExternalInvitationId { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string ContactMethod { get; set; }
        public string FromUserId { get; set; }
    }
}
