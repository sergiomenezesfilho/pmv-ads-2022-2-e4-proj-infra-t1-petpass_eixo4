﻿using System.ComponentModel.DataAnnotations;

namespace PetPassBackend.Models
{
    public class AuthenticateDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
