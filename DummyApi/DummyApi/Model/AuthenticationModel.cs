using System.ComponentModel.DataAnnotations;

namespace JWTAuthenticationDemo2.Model
{
    public class AuthenticationModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        //[Required]
        //public string Token { get; set; }
    }
}
