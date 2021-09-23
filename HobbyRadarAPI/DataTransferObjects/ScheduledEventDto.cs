using HobbyRadarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.DataTransferObjects
{
    public class ScheduledEventDto
    {
        public int HobbyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public long Date { get; set; }

        
    }
}
