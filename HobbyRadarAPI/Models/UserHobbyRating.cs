using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Models
{
    public class UserHobbyRating
    {
        public string UserId { get; set; }
        public int HobbyId { get; set; }
        public int Rating { get; set; }

        [NotMapped]
        public User User { get; set; }
        [NotMapped]
        public Hobby Hobby { get; set; }
    }
}
