using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University.Services.Model
{
    //model created
    public class UserRegisterModel
    {
       

        public string rollnumber { get; set; }

        public string FullName { get; set; }
        public string sex { get; set; }
        public string Phone { get; set; }
        public string secondaryContact { get; set; }
        public string EmailId { get; set; }
        public string contactAddress { get; set; }
        public string country { get; set; }

        public string courseID { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string UserType { get; set; }

    }
}
