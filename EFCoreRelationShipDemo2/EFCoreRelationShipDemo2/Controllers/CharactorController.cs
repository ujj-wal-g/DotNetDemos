using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelationShipDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactorController : ControllerBase
    {
        private readonly DataContext _Context;
        public CharactorController(DataContext context)
        {
            _Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<FavCharacterOfUser>>> Get(int userId)
        {
        var character = await _Context.FavCharacterOfUsers
                .Where(c => c.UserId==userId)
                .ToListAsync();
            return character;
        }
       
    }
}
