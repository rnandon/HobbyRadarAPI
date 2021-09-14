using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Models
{
    public class ConnectionInvite
    {
        public int ConnectionInviteId { get; set; }

        public string FromUserId { get; set; }
        //public User FromUser { get; set; }

        public string ToUserId { get; set; }
        //public User ToUser { get; set; }

        public string Message { get; set; }
        public bool Accepted { get; set; }
        public DateTime DateSent { get; set; }
        public bool Dismissed { get; set; }
    }
}
