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
        public async Task<IActionResult> Post(Users users)
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
        [HttpGet("id")]
        public async Task<IActionResult> GetItem(Guid id)
        {
            var user = await _unitOfWork.User.GetById(id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var user = await _unitOfWork.User.All();
            return Ok(user);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateItem( Users users)
        {
          
            await _unitOfWork.User.Upsert(users);
            await _unitOfWork.CompleteAsync();
            return NoContent();

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteItem(Guid id)
        {
            await _unitOfWork.User.Delete(id);
            await _unitOfWork.CompleteAsync();
            return Ok();

        }


    }
}
