﻿using System.ComponentModel.DataAnnotations;

namespace Tweetbook.Controllers.V1.Requests
{
    public class UserRegistrationRequest
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}