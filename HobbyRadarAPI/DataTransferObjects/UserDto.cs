using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbyRadarAPI.DataTransferObjects
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPreference { get; set; }
    }

    public class UserForUpdateDto : UserDto
    {
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public string UserZip { get; set; }
    }
}
