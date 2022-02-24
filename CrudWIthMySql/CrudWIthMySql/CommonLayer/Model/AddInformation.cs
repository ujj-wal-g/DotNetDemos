namespace CrudWIthMySql.CommonLayer.Model
{
    public class AddInformationRequest
    {
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }

    }
    public class AddInformationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
