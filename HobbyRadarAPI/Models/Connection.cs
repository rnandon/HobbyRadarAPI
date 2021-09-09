using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Models
{
    public class Connection
    {
        public string User1Id { get; set; }
        public string User2Id { get; set; }

        [NotMapped]
        public User User1 { get; set; }
        [NotMapped]
        public User User2 { get; set; }
    }
}
