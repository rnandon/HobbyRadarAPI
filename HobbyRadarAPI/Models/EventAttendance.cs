using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.Models
{
    public class EventAttendance
    {
        public int ScheduledEventId { get; set; }
        public string UserId { get; set; }

        [NotMapped]
        public ScheduledEvent ScheduledEvent{ get; set; }
        [NotMapped]
        public User User { get; set; }
    }
}
