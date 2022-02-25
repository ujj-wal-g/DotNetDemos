using CrudWIthMySql.CommonLayer.Model;
using CrudWIthMySql.CommonUtility;
using MySqlConnector;

namespace CrudWIthMySql.RepositoryLayer
{
    public class CrudApplicationRL : ICrudApplicationRL
    {
        public readonly IConfiguration _configuration;
        public readonly MySqlConnection _mySqlConnection;
        private readonly ILogger<CrudApplicationRL> _logger;
        public CrudApplicationRL(IConfiguration configuration, ILogger<CrudApplicationRL> logger)
        {
            _configuration = configuration;
            _mySqlConnection = new MySqlConnection(_configuration["ConnectionStrings:MySqlDbString"]);
            _logger = logger;
        }
        public async Task<AddInformationResponse> AddInformation(AddInformationRequest request)
        {
            _logger.LogInformation("Log information method is calling in crud application repository layer");
            AddInformationResponse response = new AddInformationResponse();
            response.IsSuccess = true;
            response.Message = "Successfull";
            try
            {
                if (_mySqlConnection.State != System.Data.ConnectionState.Open)
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
                    sqlcommand.Parameters.AddWithValue("@IsActive", request.IsActive);
                    int status = sqlcommand.ExecuteNonQuery();
                    if (status <= 0)
                    {
                        response.IsSuccess = false;
                        response.Message = "Query Not executed";
                        _logger.LogError("Log error is occurred:query does not executes");
                        return response;
                    }
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"Log error is occurred in repository layer Message{ex.Message}");

            }
            finally
            {
                _mySqlConnection.CloseAsync();
            }
            return response;
        }
         

        public async Task<ReadAllInformationResponse> ReadAllInformation()
        {
            ReadAllInformationResponse response = new ReadAllInformationResponse();
            response.IsSuccess = true;
            response.Message = "Successfull";
            try
            {
                if (_mySqlConnection.State != System.Data.ConnectionState.Open)
                {
                    await _mySqlConnection.OpenAsync();
                }
                using (MySqlCommand mySqlCommand = new MySqlCommand(SqlQueries.ReadAllInformation, _mySqlConnection))
                {
                    try
                    {
                        mySqlCommand.CommandType = System.Data.CommandType.Text;
                        mySqlCommand.CommandTimeout = 180;
                        using (MySqlDataReader datareader = await mySqlCommand.ExecuteReaderAsync())
                        {
                            if (datareader.HasRows)
                            {
                                response.readAllInformation = new List<GetReadAllInformation>();
                                while (await datareader.ReadAsync())
                                {
                                    GetReadAllInformation getdata = new GetReadAllInformation();
                                    getdata.UserId = datareader["UserId"] != DBNull.Value ? Convert.ToInt32(datareader["UserId"]) : 0;
                                    getdata.UserName = datareader["UserName"] != DBNull.Value ? Convert.ToString(datareader["UserName"]) : String.Empty;
                                    getdata.EmailId = datareader["EmailId"] != DBNull.Value ? Convert.ToString(datareader["EmailId"]) : String.Empty;
                                    getdata.MobileNo = datareader["MobileNo"] != DBNull.Value ? Convert.ToString(datareader["MobileNo"]) : String.Empty;
                                    getdata.Gender = datareader["Gender"] != DBNull.Value ? Convert.ToString(datareader["Gender"]) : String.Empty;
                                    getdata.IsActive = datareader["IsActive"] != DBNull.Value ? Convert.ToBoolean(datareader["IsActive"]) : false;
                                    getdata.Salary = datareader["Salary"] != DBNull.Value ? Convert.ToInt32(datareader["Salary"]) : 0;

                                    response.readAllInformation.Add(getdata);
                                }
                            }
                            else
                            {
                                response.IsSuccess = true;
                                response.Message = "Record not found/database is empty";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        response.IsSuccess = false;
                        response.Message = ex.Message;
                        _logger.LogError(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError("Error is Occured in crudapplicationRL" + ex.Message);
            }
            finally
            {
                _mySqlConnection.CloseAsync();
            }
            return response;
        }

        public async Task<UpdateAllInformationResponse> UpdateInformation(UpdateAllInformationRequest request)
        {
            _logger.LogInformation("Update information method is calling in crud application repository layer");
            UpdateAllInformationResponse response = new UpdateAllInformationResponse();
            response.IsSuccess = true;
            response.Message = "Successfull";
            try
            {
                if (_mySqlConnection.State != System.Data.ConnectionState.Open)
                {
                    await _mySqlConnection.OpenAsync();

                }
                using (MySqlCommand sqlcommand = new MySqlCommand(SqlQueries.UpdateInformation, _mySqlConnection))
                {
                    sqlcommand.CommandType = System.Data.CommandType.Text;
                    sqlcommand.CommandTimeout = 180;
                    sqlcommand.Parameters.AddWithValue("@UserId", request.UserId);
                    sqlcommand.Parameters.AddWithValue("@UserName", request.UserName);
                    sqlcommand.Parameters.AddWithValue("@EmailId", request.EmailId);
                    sqlcommand.Parameters.AddWithValue("@MobileNo", request.MobileNo);
                    sqlcommand.Parameters.AddWithValue("@Gender", request.Gender);
                    sqlcommand.Parameters.AddWithValue("@Salary", request.Salary);
                    int status = sqlcommand.ExecuteNonQuery();
                    if (status <= 0)
                    {
                        response.IsSuccess = false;
                        response.Message = "Query Not executed";
                        _logger.LogError("Log error is occurred:query does not executes");
                        return response;
                    }
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"UpdateAllInformation gives error in repository layer Message{ex.Message}");

            }

            finally
            {

                _mySqlConnection.CloseAsync();

            }
            return response;

        }

        public async Task<DeleteInformationResponse> DeleteInformation(DeleteInformationRequest request)
        {
            _logger.LogInformation("Log information method is calling in crud application repository layer");
            DeleteInformationResponse response = new DeleteInformationResponse();
            response.IsSuccess = true;
            response.Message = "Successfull";
            try
            {
                if (_mySqlConnection.State != System.Data.ConnectionState.Open)
                {
                    await _mySqlConnection.OpenAsync();
                }
                using (MySqlCommand sqlcommand = new MySqlCommand(SqlQueries.DeleteInformation, _mySqlConnection))
                {
                    sqlcommand.CommandType = System.Data.CommandType.Text;
                    sqlcommand.CommandTimeout = 180;
                    sqlcommand.Parameters.AddWithValue("@UserId", request.UserId);
                    int status = sqlcommand.ExecuteNonQuery();
                    if (status <= 0)
                    {
                        response.IsSuccess = false;
                        response.Message = "Query Not executed";
                        _logger.LogError("Log error is occurred:query does not executes");
                        return response;
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"Log error is occurred in repository layer Message{ex.Message}");
            }

            finally
            {
                _mySqlConnection.CloseAsync();
            }
            return response;
        }

        public async Task<GetAllDeleteInformationResponse> GetAllDeleteInformation()
        {

            GetAllDeleteInformationResponse response = new GetAllDeleteInformationResponse();
            response.IsSuccess = true;
            response.Message = "Successfull";
            try
            {
                if (_mySqlConnection.State != System.Data.ConnectionState.Open)
                {
                    await _mySqlConnection.OpenAsync();
                }
                using (MySqlCommand mySqlCommand = new MySqlCommand(SqlQueries.GetAllDeleteInformation, _mySqlConnection))
                {
                    try
                    {
                        mySqlCommand.CommandType = System.Data.CommandType.Text;
                        mySqlCommand.CommandTimeout = 180;
                        using (MySqlDataReader datareader = await mySqlCommand.ExecuteReaderAsync())
                        {
                            if (datareader.HasRows)
                            {
                                response.Requests = new List<GetAllDeleteInformationRequest>();
                                while (await datareader.ReadAsync())
                                {
                                    GetAllDeleteInformationRequest getdata = new GetAllDeleteInformationRequest();
                                    getdata.UserId = datareader["UserId"] != DBNull.Value ? Convert.ToInt32(datareader["UserId"]) : 0;
                                    getdata.UserName = datareader["UserName"] != DBNull.Value ? Convert.ToString(datareader["UserName"]) : String.Empty;
                                    getdata.EmailId = datareader["EmailId"] != DBNull.Value ? Convert.ToString(datareader["EmailId"]) : String.Empty;
                                    getdata.MobileNo = datareader["MobileNo"] != DBNull.Value ? Convert.ToString(datareader["MobileNo"]) : String.Empty;
                                    getdata.Gender = datareader["Gender"] != DBNull.Value ? Convert.ToString(datareader["Gender"]) : String.Empty;

                                    getdata.Salary = datareader["Salary"] != DBNull.Value ? Convert.ToInt32(datareader["Salary"]) : 0;

                                    response.Requests.Add(getdata);
                                }
                            }
                            else
                            {
                                response.IsSuccess = true;
                                response.Message = "Record not found/database is empty";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        response.IsSuccess = false;
                        response.Message = ex.Message;
                        _logger.LogError(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError("Error is Occured in crudapplicationRL" + ex.Message);
            }
            finally
            {
                _mySqlConnection.CloseAsync();
            }
            return response;
        }
    }
}
