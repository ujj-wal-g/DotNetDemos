using System.ComponentModel.DataAnnotations;

namespace CrudWIthMySql.CommonLayer.Model
{
    public class DeleteInformationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    public class DeleteInformationRequest
    {
        [Required(ErrorMessage ="UserId is required")]
        public int  UserId { get; set; }
       
    }
}
