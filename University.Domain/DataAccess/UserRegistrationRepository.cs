using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.DataAccess.Interface;
using University.Domain.Entities;

namespace University.Domain.DataAccess
{
   public class UserRegistrationRepository : IUserRegistrationRepository
    {
        private readonly UniversityContext _context;

        public string Insert(UserRegister userregister)
        {

            _context.Add(userregister);
                _context.SaveChanges();
            return userregister.Username;
        }

    }
}
