﻿using System;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.Model.Dto.UserDto
{
    public class UserAddDto
    {
        public string Name { get; set; }
        public string Email { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Minimum length should be 8 characters,1 capital letter,1 special character,1 numeric character")]
        public string Password { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
