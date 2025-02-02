using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineBookShoop_Razor.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]         //Server site Validation
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]  //custom error messege
        public int DisplayOrder { get; set; }
    }
}
