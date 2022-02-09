using System.ComponentModel.DataAnnotations;

namespace BookStore.Model
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
