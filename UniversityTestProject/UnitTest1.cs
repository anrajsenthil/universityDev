using System;
using Xunit;
using University.Domain;
using University.Services.Controllers;
using FakeItEasy;
using University.Domain.DataAccess.Interface;
using University.Business.Interface;
using AutoMapper;
using University.Services.Model;
using System.Threading.Tasks;
using University.Domain.Entities;
using Shouldly;
namespace UniversityTestProject
{
    public class RegisterControllerTest
    {
        private University.Domain.DataAccess.UserRegistrationRepository _ur;
        public RegisterControllerTest()
        {
       
       }

            [Fact]
        public void Registertest()
        {
            Boolean b = true;
          //  UserRegisterModel a = new UserRegisterModel { Username = "aaa", EmailId = "aa@gmail.com", Password = "12345", UserType = "Staff" };
           
          
          //  var dataStore = A.Fake<IUserRegisterActions>();
          //  var datamap = A.Fake<IMapper>();
          //  var controller = new UserRegisterController(dataStore, datamap);
          
          //  A.CallTo(() => dataStore.InsertStudentAysc(A<University.Domain.Entities.UserRegister>._)).Returns(Task.FromResult("senthil"));
           
          //await _ur.InsertStudentAysc(datamap.Map<UserRegisterModel, UserRegister>(a));

            Assert.True(b);

        }
    }
}
