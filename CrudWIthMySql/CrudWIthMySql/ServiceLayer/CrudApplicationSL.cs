using CrudWIthMySql.CommonLayer.Model;
using CrudWIthMySql.RepositoryLayer;
using System.Text.RegularExpressions;

namespace CrudWIthMySql.ServiceLayer
{
    public class CrudApplicationSL:ICrudApplicationSL
    {
        private readonly ICrudApplicationRL _crudApplicationRL;
        public readonly string EmailRegex = @"^[A-Za-z._]{3,}@[A-Za-z]{3,}[.]{1}[A-Za-z]{2,6}([.][A-za-z]{2,6})?$";
        public readonly string MobileRegex = @"((\+*)((0[ -]*)*|((91 )*))((\d{12})+|(\d{10})+))|\d{5}([- ]*)\d{6}";
        public readonly string GenderRegex = @"^(?:m|Male|male|f|Female|female)$";
        private readonly ILogger<CrudApplicationSL> _logger;
        public CrudApplicationSL(ICrudApplicationRL crudApplicationRL,ILogger<CrudApplicationSL> logger)
        {
            _crudApplicationRL = crudApplicationRL;
            _logger = logger;
        }

        public async Task<AddInformationResponse> AddInformation(AddInformationRequest request)
        { 
           
           AddInformationResponse response = new AddInformationResponse();
            
            if(string.IsNullOrEmpty(request.EmailId))
            {
                response.IsSuccess = false;
                response.Message = "Email can not be empty or null";
                return response;
            }
            else
            {
                if(!(Regex.IsMatch(request.EmailId,EmailRegex)))
                {
                    response.IsSuccess=false;
                    response.Message = "Email should be in correct format ex:ujjwal@gmail.com";
                    return response;
                }
            }
            if (string.IsNullOrEmpty(request.UserName))
            {
                response.IsSuccess = false;
                response.Message = "UserName can not be empty or null";
                return response;
            }
            if (string.IsNullOrEmpty(request.Gender))
            {
                response.IsSuccess = false;
                response.Message = "Gender can not be empty or null";
                return response;
            }
            else
            {
                if(!(Regex.IsMatch(request.Gender,GenderRegex)))
                {
                    response.IsSuccess = false;
                    response.Message = "Gender should be match with one option: m,Male,male,f,Female,female";
                    return response;
                }
            }
            if (request.Salary<=0)
            {
                response.IsSuccess = false;
                response.Message = "Salary can not less or equal than to zero";
                return response;
            }
            if(string.IsNullOrEmpty(request.MobileNo))
            {
                response.IsSuccess= false;
                response.Message = "Mobile number can not be null or empty";
                return response;
            }
            else
            {
                if(!(Regex.IsMatch(request.MobileNo,MobileRegex)))
                {
                    response.IsSuccess=false;
                    response.Message = "Mobile number is not valid";
                    return response;
                }
            }
            _logger.LogInformation("Add method is calling in crudapplicationSL");
            return await _crudApplicationRL.AddInformation(request);
        }

        public async Task<ReadAllInformationResponse> ReadAllInformation()
        {
            _logger.LogInformation("ReadInformation is calling in crudapplication service layer");
            return  await  _crudApplicationRL.ReadAllInformation();
        }

        public async Task<UpdateAllInformationResponse> UpdateInformation(UpdateAllInformationRequest request)
        {
            _logger.LogInformation("UpdateInformation is calling in crudapplication service layer");
            return await _crudApplicationRL.UpdateInformation(request);

        }

        public async Task<DeleteInformationResponse> DeleteInformation(DeleteInformationRequest request)
        {
            _logger.LogInformation("DeleteInformation is calling in crudapplication service layer");
            return await _crudApplicationRL.DeleteInformation(request);
        }

        public async  Task<GetAllDeleteInformationResponse> GetAllDeleteInformation()
        {
            _logger.LogInformation("GetAllDeleteInformation is calling in crudapplication service layer");
            return await _crudApplicationRL.GetAllDeleteInformation();
        }
    }
} 
