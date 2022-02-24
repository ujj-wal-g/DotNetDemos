using CrudWIthMySql.CommonLayer.Model;
using CrudWIthMySql.CommonUtility;
using MySqlConnector;

namespace CrudWIthMySql.RepositoryLayer
{
    public class CrudApplicationRL : ICrudApplicationRL
    {
        public readonly IConfiguration _configuration;
        public readonly MySqlConnection _mySqlConnection;
        public CrudApplicationRL(IConfiguration configuration)
        {
            _configuration = configuration;
            _mySqlConnection = new MySqlConnection(_configuration["ConnectionStrings:MySqlDbString"]);
        }
        public async Task<AddInformationResponse> AddInformation(AddInformationRequest request)
        {
            
            AddInformationResponse response = new AddInformationResponse();
            response.IsSuccess= true;
            response.Message = "sucessfull";
            try
            {
            if(_mySqlConnection.State!=System.Data.ConnectionState.Open)
            {
                    await _mySqlConnection.OpenAsync();
            }
                using (MySqlCommand sqlcommand = new MySqlCommand(SqlQueries.AddInformation, _mySqlConnection))
                {
                    sqlcommand.CommandType = System.Data.CommandType.Text;
                    sqlcommand.CommandTimeout = 180;
                    sqlcommand.Parameters.AddWithValue("@UserName", request.UserName);
                    sqlcommand.Parameters.AddWithValue("@EmailId", request.EmailId);
                    sqlcommand.Parameters.AddWithValue("@MobileNo", request.MobileNo);
                    sqlcommand.Parameters.AddWithValue("@Gender", request.Gender);
                    sqlcommand.Parameters.AddWithValue("@Salary", request.Salary);
                    int status = sqlcommand.ExecuteNonQuery();
                    if(status<=0)
                    {
                    response.IsSuccess = false;
                    response.Message = "Query Not executed";
                    return response;
                    }
                }

            }catch (Exception ex)
            {
                response.IsSuccess=false;
                response.Message = ex.Message;

            }
            finally
            {
                _mySqlConnection.CloseAsync();
                _mySqlConnection.DisposeAsync();
            }
            return response;
        }
    }
}
