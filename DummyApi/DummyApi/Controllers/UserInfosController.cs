using JWTAuthenticationDemo2.IServices;
using JWTAuthenticationDemo2.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthenticationDemo2.Controllers
{
    
    public class UserInfosController : ControllerBase
    {
        private IUserInfoServices _userInfoService;
        public UserInfosController(IUserInfoServices userInfoServices)
        {
            _userInfoService = userInfoServices;
        }
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticationModel model)
        {
            var user = _userInfoService.Authenticate(model.UserName, model.Password);
            if (user == null) return BadRequest(new { message ="Username and password is incorrect"});
            return Ok(user);
        }

        [Authorize]

        [HttpGet("test")]
        public IEnumerable<string>Get()
        {
            return new string[] {"********User secrets*******" };
        }
       

    }
}
