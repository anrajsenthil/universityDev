﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University.Services.Model
{
    //model created
    public class UserRegisterModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string EmailId { get; set; }
        public string Phone { get; set; }
        public string UserType { get; set; }

    }
}
