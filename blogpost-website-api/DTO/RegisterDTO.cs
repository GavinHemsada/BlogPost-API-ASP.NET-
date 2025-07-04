﻿using System.ComponentModel.DataAnnotations;

namespace blogpost_website_api.DTO
{
    public class RegisterDTO
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "admin";  
    }
}
