using System.ComponentModel.DataAnnotations;

namespace JWTAuthentication.Model
{
    public class UserInfo
    {
        [Key]
        public Guid UserInfoId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Token { get; set; }
    }
}
