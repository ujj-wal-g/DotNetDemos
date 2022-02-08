using System.ComponentModel.DataAnnotations;

namespace UserAuthorizationDemo1.Model
{
    public class UserRecord
    {
        [Key]
        public string UserName { get; set; }

        public string Token { get; set; }
        public string Password { get; set; }
    }
}
