using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.DataTransferObjects
{
    public class HobbyDto
    {
        public string Name { get; set; }
        public int HobbyId { get; set; }
        public List<string> Tags { get; set; }
    }
}
