using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
