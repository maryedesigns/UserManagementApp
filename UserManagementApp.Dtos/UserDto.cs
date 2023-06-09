﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementApp.Dtos
{
    public class UserDto
    {        
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Address { get; set; }
    }
}
