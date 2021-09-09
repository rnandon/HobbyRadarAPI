using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Models
{
    public class HobbyTag
    {
        public int HobbyId { get; set; }
        public int TagId { get; set; }

        [NotMapped]
        public Hobby Hobby { get; set; }
        [NotMapped]
        public Tag Tag { get; set; }
    }
}
