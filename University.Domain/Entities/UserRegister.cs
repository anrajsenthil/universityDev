using System;
using System.Collections.Generic;
using System.Text;

namespace University.Domain.Entities
{
   public class UserRegister
    {

        
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string EmailId { get; set; }
        public string Phone { get; set; }

        public string courseID { get; set; }

        public string country { get; set; }

        public string permentAddress { get; set; }

        public string contactAddress { get; set; }

        public string FullName { get; set; }

        public string passportNumber { get; set; }
    }
}
