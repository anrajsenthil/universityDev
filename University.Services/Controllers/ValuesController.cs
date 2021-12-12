using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Services.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace University.Services.Controllers
{
   
    public class ValuesController : ControllerBase
    {
        [Route("aaa")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        public ValuesController(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [Route("createuser")]
        [HttpGet]
        public async Task<ActionResult> InsertUserget()
        {
            var user = new IdentityUser
            {
                // UserType=model.UserType,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var result = await _userManager.AddToRoleAsync(user, "Staff");
            return Ok(new { result.Errors });
        }

            [Route("createuser")]
        [HttpPost]
        public async Task<ActionResult> InsertUser([FromBody] UserRegisterModel model)
        {
            var user = new IdentityUser
            {
                Email = model.EmailId,
                UserName = model.Username,
                // UserType=model.UserType,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                if (model.UserType == "Staff")
                {
                    await _userManager.AddToRoleAsync(user, "Staff");
                }
                else if (model.UserType == "Student")
                {
                    await _userManager.AddToRoleAsync(user, "Student");
                }
                else
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
                return Ok(new { Username = user.UserName });
            }

            return Ok(new { result.Errors });
        }

       

    }
}
