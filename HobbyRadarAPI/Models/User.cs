using Microsoft.AspNetCore.Identity;

namespace HobbyRadarAPI.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
