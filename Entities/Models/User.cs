﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class User: IdentityUser
    {
        [MaxLength(70)]
        public string FirstName { get; set; }
        [MaxLength(70)]
        public string LastName { get; set; }
        [MaxLength(70)]
        public string MiddleName { get; set; }
        public DateTime LastLoginAt { get; set; }
        public DateTime LastActivityAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
