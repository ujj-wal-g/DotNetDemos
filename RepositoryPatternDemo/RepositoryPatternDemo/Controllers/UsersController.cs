using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.Core.IConfiguration;
using RepositoryPatternDemo.Core.IRepositories;
using RepositoryPatternDemo.Core.Repositories;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        
        public UsersController(ILogger<UsersController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            
        }
        [HttpPost]
        public async Task<IActionResult> Post(User users)
        {
            if(ModelState.IsValid)
            {
                users.Id = new Guid();
                await _unitOfWork.User.Add(users);
                await _unitOfWork.CompleteAsync();

                return CreatedAtAction("GetItem",new {users.Id},users);
                
            }
            return new JsonResult("Something went wrong ") { StatusCode = 500 };
        }
       
    }
}
