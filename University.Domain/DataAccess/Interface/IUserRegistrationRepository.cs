using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace University.Domain.DataAccess.Interface
{
   public interface IUserRegistrationRepository
    {
      //  Task<(bool IsSuccess, UserRegister userreg , String ErrorMsg)> InsertStudentAysc(UserRegister userreg);
        Task<string> InsertStudentAysc(UserRegister userregister);
        string Insert(UserRegister userreg);
    }
}
