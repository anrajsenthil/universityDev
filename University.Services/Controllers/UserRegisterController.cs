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
   //controller working repo devbranch
    public class UserRegisterController : ControllerBase
    {
        private readonly IUserRegisterActions _userRegisterActions;
        private readonly IMapper _mapper;
        public UserRegisterController(IUserRegisterActions userRegisterActions,IMapper mapper)
        {
            _userRegisterActions = userRegisterActions;
            _mapper = mapper;
        }


        [Route("stureg")]
        [HttpPost]
        public async Task<ActionResult> studentRegister([FromBody] UserRegisterModel userRegisterModel)
        {
            await _userRegisterActions.InsertStudentAysc(_mapper.Map<UserRegisterModel, UserRegister>(userRegisterModel));

            return Ok(new { Username = userRegisterModel.FullName });
        }
    }
   
}