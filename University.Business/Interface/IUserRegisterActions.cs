using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;

namespace University.Business.Interface
{
   public interface IUserRegisterActions
    {
        string Insert(UserRegister userreg);
        Task<string> InsertStudentAysc(UserRegister userregister);
    }
}
