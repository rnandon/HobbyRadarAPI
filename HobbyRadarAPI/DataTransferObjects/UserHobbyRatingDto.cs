using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.DataTransferObjects
{
    public class UserHobbyRatingDto
    {
        public int HobbyId { get; set; }
        public string UserId { get; set; }
    }
}
