using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EmailDemo3.model
{
    public class MailRequest
    {
        [EmailAddress]
        public string ToEmail { get; set; }
        [StringLength(250, ErrorMessage ="Subject should be short and descriptive")]
        public string Subject { get; set; }
        public string Body { get; set; }
      public List<IFormFile> Attachements { get; set; }
    }
}
