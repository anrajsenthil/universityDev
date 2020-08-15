using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Business.Interface;
using University.Domain.Entities;
using University.Services.Model;

namespace University.Services.Controllers
{
   //controller
    public class UserRegisterController : ControllerBase
    {
        private readonly IUserRegisterActions _userRegisterActions;
        private readonly IMapper _mapper;
        public UserRegisterController(IUserRegisterActions userRegisterActions,IMapper mapper)
        {
            _userRegisterActions = userRegisterActions;
            _mapper = mapper;
        }
        
       
        [Route("Insert")]
        [HttpPost]
        public void Insert([FromBody]UserRegisterModel userRegisterModel)
        {
           // _userRegisterActions.Insert(_mapper.Map<UserRegisterModel, UserRegister>(userRegisterModel));
           // return Ok("User Register Sucessfully");
        }
    }
   
}