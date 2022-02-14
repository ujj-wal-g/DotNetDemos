using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelValidationDemo.Model;

namespace ModelValidationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    { 
        [HttpPost("[Action]")]

        public IActionResult PostPerson(PersonModel personModel)
        {
            return Ok();
        }

        [HttpPost("[Action]")]

        public IActionResult PostFluentPerson(FluentPersonModel personModel)
        {
            return Ok();
        }
    }
}
