using CrudWIthMySql.CommonLayer.Model;
using CrudWIthMySql.ServiceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudWIthMySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudApplicationController : ControllerBase
    {
        private readonly ICrudApplicationSL _crudApplicationSL;
        public CrudApplicationController(ICrudApplicationSL crudApplicationSL)
        {
            _crudApplicationSL = crudApplicationSL;
        }
        [HttpPost]
        public async Task<IActionResult> AddInformation(AddInformationRequest request )
        { 
            AddInformationResponse response = new AddInformationResponse();
            try
            {
               response= await _crudApplicationSL.AddInformation(request);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return Ok(response);

        }
    }
}
