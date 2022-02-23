using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VersioningDemo.Model;

namespace VersioningDemo.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("1.0",Deprecated =true)]
    public class UsersController : ControllerBase
    {
        List<UserV1> user = new List<UserV1>()
        {
            new UserV1()
            {
            Id = 1,
            Name ="Ujjwal"
            },
            new UserV1()
            {
            Id = 2,
            Name ="Aarav"
            },
            new UserV1()
            {
            Id = 3,
            Name ="Arnav"
            }
        };
        [HttpGet]
        public List<UserV1> Get()
        {
            return user.ToList();
        }
    }
}
