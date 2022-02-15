using System.ComponentModel.DataAnnotations;

namespace CRUDDemo.Model
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must have atleast 2 chars and upmost 50 chars")]
        public string Name { get; set; }
    }
}
