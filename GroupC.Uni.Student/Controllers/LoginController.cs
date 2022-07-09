using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GroupC.Uni.Student.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace GroupC.Uni.Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Login(string username, string pass)
        {
            StudentModel login = new StudentModel();
            login.UserName = username;
            login.Password = pass;
            IActionResult response = Unauthorized();

            var user = AuthenticateUser(login);
            if (user != null)
            {
                var tokenStr = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenStr });
            }

            return response;
        }

        private StudentModel AuthenticateUser(StudentModel login)
        {
            StudentModel user = null;
            if (login.UserName == "rami" && login.Password == "123")
            {
                user = new StudentModel { UserName = "rami", Password = "123" };
            }
            return user;
        }

        private string GenerateJSONWebToken(StudentModel userInfo)
        {
            // sec key
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

            //signing token
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,userInfo.UserName),
                //new Claim(JwtRegisteredClaimNames.Email,userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            //create token 
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                expires: DateTime.Now.AddHours(1),
                signingCredentials: signingCredentials,
                claims: claims);



            //return token
            //write token will return string
            var encodeToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodeToken;
        }
        [HttpPost("Post")]
        [Authorize]
        public string Post()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claim = identity.Claims.ToList();
            var userName = claim[0].Value;
            return "Welcome to: " + userName;
        }
        [HttpGet("GetValue")]
        [Authorize]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Value1", "Value2" };
        }
    }
}