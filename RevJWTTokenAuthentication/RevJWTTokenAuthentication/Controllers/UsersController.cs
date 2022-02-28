using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RevJWTTokenAuthentication.Model;
using RevJWTTokenAuthentication.Repository;

namespace RevJWTTokenAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    
    public class UsersController : ControllerBase
    {
        private readonly IJwtManagerRepository _jwtManagerRepository;
        public UsersController(IJwtManagerRepository jwtManagerRepository)
        {
            _jwtManagerRepository = jwtManagerRepository;
        }
        [HttpGet]
        public List<string>Get()
        {
            var users = new List<string> { "Anand,Abhay,Sourav" };
            return users;
        }
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult authenticate (Users user)
        {
            var token = _jwtManagerRepository.authenticate(user);
            if(token ==null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
