using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Models
{
    public class Hobby
    {
        public int HobbyId { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public IEnumerable<Tag> Tags { get; set; }
    }
}
