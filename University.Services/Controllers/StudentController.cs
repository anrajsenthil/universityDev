using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using University.Business.Interface;
using University.Domain.Entities;
using University.Services.Model;

namespace University.Services.Controllers
{
    [Route("api/[Student]")]
    [Produces("application/json")]
    public class StudentController : ControllerBase
    {
        public readonly IStudentRetriever _studentRetriever;
        public readonly IMapper _mapper;
       

        public StudentController(IStudentRetriever studentRetriever,IMapper mapper )
        {
            _studentRetriever = studentRetriever;
            _mapper = mapper;
        }
        public IActionResult Get()
        {
            return Ok(_mapper.Map<List<Student>,List<StudentModel>>(_studentRetriever.RetrieveAll()));
        }
    }
}