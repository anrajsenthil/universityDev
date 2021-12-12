using System;
using System.Collections.Generic;
using System.Text;

namespace University.Domain.Entities
{
   public class UserRegister
    {
        public string rollnumber { get; set; }

        public string FullName { get; set; }
        public string sex { get; set; }
        public string Phone { get; set; }
        public string secondaryContact { get; set; }
        public string EmailId { get; set; }
        public string contactAddress { get; set; }
      
        public List<Courses> courseID { get; set; }
        public List<Country> country { get; set; }
             

        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


    }
}
