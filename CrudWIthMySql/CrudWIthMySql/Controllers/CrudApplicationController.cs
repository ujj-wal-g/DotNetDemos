using CrudWIthMySql.CommonLayer.Model;
using CrudWIthMySql.ServiceLayer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrudWIthMySql.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CrudApplicationController : ControllerBase
    {
        private readonly ICrudApplicationSL _crudApplicationSL;
        private readonly ILogger<CrudApplicationController> _logger;
        public CrudApplicationController(ICrudApplicationSL crudApplicationSL, ILogger<CrudApplicationController> logger)
        {
            _crudApplicationSL = crudApplicationSL;
            _logger = logger;
        }
        
        [HttpGet]
        public async Task<IActionResult> ReadAllInformation()
        {
            ReadAllInformationResponse response = new ReadAllInformationResponse();
            _logger.LogInformation($"LogInformation is calling in controller!");
            try
            {
                response = await _crudApplicationSL.ReadAllInformation();
                if (!(response.IsSuccess))
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message,Data= response.readAllInformation });

                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"Log error is occur in controller!Message={ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
            }
            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message,Data= response.readAllInformation });

        }
       
        [HttpGet]
        public async Task<IActionResult> GetAllInActiveInformation()
        {
            GetAllDeleteInformationResponse response = new GetAllDeleteInformationResponse();
            _logger.LogInformation($"LogInformation is calling in controller!");
            try
            {
                response = await _crudApplicationSL.GetAllDeleteInformation();
                if (!(response.IsSuccess))
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message, Data = response.Requests});

                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"Log error is occur in controller!Message={ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
            }
            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message, Data = response.Requests });

        }

        [HttpPost]
        public async Task<IActionResult> AddInformation(AddInformationRequest request)
        {
            AddInformationResponse response = new AddInformationResponse();
            _logger.LogInformation($"LogInformation is calling in controller!", JsonConvert.SerializeObject(request));
            try
            {
                response = await _crudApplicationSL.AddInformation(request);
                if (!(response.IsSuccess))
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });

                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"Log error is occur in controller!Message={ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
            }
            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });

        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateAllInformation(UpdateAllInformationRequest request)
        {
            UpdateAllInformationResponse response = new UpdateAllInformationResponse();
            _logger.LogInformation($"LogInformation is calling in controller!", JsonConvert.SerializeObject(request));
            try
            {
                response = await _crudApplicationSL.UpdateInformation(request);
                if (!(response.IsSuccess))
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });

                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"Log error is occur in controller!Message={ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
            }
            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteInformation(DeleteInformationRequest request)
        {
            DeleteInformationResponse response = new DeleteInformationResponse();
            _logger.LogInformation($"LogInformation is calling in controller!", JsonConvert.SerializeObject(request));
            try
            {
                response = await _crudApplicationSL.DeleteInformation(request);
                if (!(response.IsSuccess))
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });

                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"Log error is occur in controller!Message={ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
            }
            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });
        }



    }
}
