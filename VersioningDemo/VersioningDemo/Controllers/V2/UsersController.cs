using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VersioningDemo.Model;

namespace VersioningDemo.Controllers.V2
{
    //[Route("api/v{version:ApiVersion}/[controller]")]
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("2.0")]
    public class UsersController : ControllerBase
    {
        List<UserV2> user = new List<UserV2>()
        {
            new UserV2()
            {
            Id = Guid.NewGuid(),
            Name ="Ujjwal"
            },
            new UserV2()
            {
            Id = Guid.NewGuid(),
            Name ="Aarav"
            },
            new UserV2()
            {
            Id =Guid.NewGuid(),
            Name ="Arnav"
            }
        };
        [HttpGet]
        public List<UserV2> Get()
        {
            return user.ToList();
        }
    }
}
