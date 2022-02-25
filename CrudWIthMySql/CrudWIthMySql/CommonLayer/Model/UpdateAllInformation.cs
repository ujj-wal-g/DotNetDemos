using System.ComponentModel.DataAnnotations;

namespace CrudWIthMySql.CommonLayer.Model
{
    public class UpdateAllInformationRequest
    {
        [Required(ErrorMessage = "UserId is Required")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z._]{3,}@[A-Za-z]{3,}[.]{1}[A-Za-z]{2,6}([.][A-za-z]{2,6})?$"
        , ErrorMessage = "Emailid is not in correct format")]
        public string EmailId { get; set; }
        [Required]
        public string MobileNo { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public string Gender { get; set; }


    }
    public class UpdateAllInformationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

}
