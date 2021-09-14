using HobbyRadarAPI.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Models
{
    public class ScheduledEvent
    {
        public int ScheduledEventId { get; set; }
        [ForeignKey("Hobby")]
        public int HobbyId { get; set; }
        public Hobby Hobby { get; set; }

        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        [NotMapped]
        public List<AttendingUserDto> Attendees { get; set; }
    }
}
