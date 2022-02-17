using EmailDemo3.model;
using EmailDemo3.Services;
using MailKit;
using Microsoft.AspNetCore.Mvc;

namespace EmailDemo3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IMailServices _imailService;
        public EmailController(IMailServices mailService)
        {
            _imailService = mailService;
        }
        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest mailRequest)
        {
            try
            {
                await _imailService.SendEmailAsync(mailRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
