using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserAuthorizationDemo1.Model;

namespace UserAuthorizationDemo1.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    
    public class WeatherForecastController : ControllerBase
    {

        private readonly UserContext _dbContext;
        private readonly JWTSettings _jwtsettings;
        public WeatherForecastController(UserContext dbContext,IOptions<JWTSettings>jwtsettings)
        {
            _dbContext = dbContext;
            _jwtsettings = jwtsettings.Value;
        }
        [Authorize]
        [HttpGet("Get")]
        public async Task<ActionResult<UserRecord>> Get()
        {
            string username = HttpContext.User.Identity.Name;
            var user = _dbContext.userRecords
                .Where(u => u.UserName == username)
                .FirstOrDefault();
            return user;

        }
        
        [HttpPost("Login")]
        public async Task<ActionResult> Login([FromBody]UserRecord user)
        {
            var User =  _dbContext.userRecords.Where(
                u=>u.UserName == user.UserName && u.Password==user.Password && u.Token==user.Token).FirstOrDefault();
           //  userWithToken = user;
            if(User == null)
            {
                return NotFound();
            }
            //sign your token here
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtsettings.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject= new ClaimsIdentity(new Claim[]
                {new Claim(ClaimTypes.Name,user.UserName)
                }),
                Expires= DateTime.UtcNow.AddMonths(6),
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var Token = tokenHandler.WriteToken(token);
            return Ok(Token);
        }
        [Authorize]
        [HttpGet("TestUser")]
        public string TestUser()
        {
            return "*****User is Authorize*****";
        }


        //C:\Users\PC\source\repos\DotNetDemos\UserAuthorizationDemo1\UserAuthorizationDemo1\UserAuthorizationDemo1.csproj

    }
}