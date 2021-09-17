﻿using System.ComponentModel.DataAnnotations;

namespace HobbyRadarAPI.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public string UserZip { get; set; }

    }
}
