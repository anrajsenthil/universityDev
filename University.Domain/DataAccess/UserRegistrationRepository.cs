using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.DataAccess.Interface;
using University.Domain.Entities;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace University.Domain.DataAccess
{
   public class UserRegistrationRepository : IUserRegistrationRepository
    {
        private readonly UniversityContext _context;
        private readonly ILogger<UserRegistrationRepository> _logger;
      

        public UserRegistrationRepository(UniversityContext context, ILogger<UserRegistrationRepository> logger)
        {
            this._context = context;
            this._logger = logger;
        }

        public string Insert(UserRegister userregister)
        {

            _context.UserRegisters.Add(userregister);
                _context.SaveChanges();
            return userregister.Username;
        }

        public async Task<string> InsertStudentAysc(UserRegister userregister1)
        {
            _context.UserRegisters.Add(userregister1);
            await _context.SaveChangesAsync();
            return "OK";

        }
        //public async Task<(bool IsSuccess, UserRegister userregister, String ErrorMsg)> InsertStudentAysc(UserRegister userregister1)
        //{
        //    try
        //    {
        //        _context.UserRegisters.Add(userregister1);
        //       var f= await _context.SaveChangesAsync();
        //        if(f != null)
        //        {
        //            return (true, userregister1, "not found");
        //        }
        //        return (true, userregister1, "not found");
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger?.LogError(ex.ToString());
        //        return (false, null, ex.Message);
        //    }


        //}

    }
}
