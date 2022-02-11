using BookStore.Model;
using BookStore.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class ApplicationController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public ApplicationController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody]SignUpModel signUpModel)
        {
            var result = await _accountRepository.SignUpAsync(signUpModel);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }
       
        [HttpPost("Login")]
        
        public async Task<IActionResult> Login([FromBody] SignInModel signinModel)
        {
            var result = await _accountRepository.LoginAsync(signinModel);
          if(string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);
        }
    }
}
