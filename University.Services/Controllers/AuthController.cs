using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using University.Services.Model;

namespace University.Services.Controllers
{

    public class AuthController : ControllerBase
    {
        public readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        public AuthController(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }
       [Route("register")]
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
            if(result.Succeeded)
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
                    return Ok(new {Username=user.UserName });
            }

            return Ok(new {result.Errors });
        }
        [Route("login")]
        [HttpPost]
        public async Task<ActionResult> Login([FromBody] LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.username);
            if(user!=null&& await _userManager.CheckPasswordAsync(user,model.password))
            {
                var claim = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,user.UserName)
                };
            }
            var signinkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SigningKey"]));
            int expiryInMinutes = Convert.ToInt32(_configuration["Jwt:ExpiryInMinutes"]);

            var token = new JwtSecurityToken(
                issuer:_configuration["Jwt:Site"],
                 audience: _configuration["Jwt:Site"],
                  expires: DateTime.UtcNow.AddMinutes(expiryInMinutes),
                  signingCredentials: new SigningCredentials(signinkey,SecurityAlgorithms.HmacSha256)
                );
           
            return Ok(
            new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expiration=token.ValidTo
            });
            
        }
       
    }
}