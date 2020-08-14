using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Domain.Entities;
using University.Services.Model;

namespace University.Services.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegister, UserRegisterModel>().ReverseMap();
        }
    }
}
