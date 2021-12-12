using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using University.Business.Interface;
using University.Domain.DataAccess.Interface;
using University.Domain.Entities;

namespace University.Business
{
    public class UserRegisterActions : IUserRegisterActions
    {

        private readonly IUserRegistrationRepository _userRegistrationRepository;

        public UserRegisterActions(IUserRegistrationRepository userRegistrationRepository) => _userRegistrationRepository = userRegistrationRepository;

        public string Insert(UserRegister userregister)
        {
            return _userRegistrationRepository.Insert(userregister);
        }
        public async Task<string> InsertStudentAysc(UserRegister userregister1)
        {
            await _userRegistrationRepository.InsertStudentAysc(userregister1);
            return "OK";
        }
    }
}
