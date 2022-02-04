using System.ComponentModel.DataAnnotations;

namespace BasicAuthentication
{
    public class UserAuthentication
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
