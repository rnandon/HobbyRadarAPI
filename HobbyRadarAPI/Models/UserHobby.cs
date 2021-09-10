using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Models
{
    public class UserHobby
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int HobbyId { get; set; }
        public Hobby Hobby { get; set; }
    }
}
