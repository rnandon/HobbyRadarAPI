using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Models
{
    public class UserAlert
    {
        public int UserAlertId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        public string Message { get; set; }
        public string Method { get; set; }
        public bool Dismissed { get; set; }
    }
}
