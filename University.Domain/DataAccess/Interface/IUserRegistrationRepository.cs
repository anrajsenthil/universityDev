using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Entities;

namespace University.Domain.DataAccess.Interface
{
   public interface IUserRegistrationRepository
    {

        string Insert(UserRegister userreg);
    }
}
