using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.DataTransferObjects
{
    public class ConnectionInviteDto
    {
        public string FromUserId { get; set; }

        public string ToUserId { get; set; }

        public string Message { get; set; }
        public string Accepted { get; set; }
        public long DateSent { get; set; }
        public string Dismissed { get; set; }
    }
}
