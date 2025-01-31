using System.ComponentModel.DataAnnotations;

namespace OnlineBookShoop.Models
{
    public class Category
    {
        [Key]
        public int Key { get; set; }

        [Required]
        public string Name { get; set; } 
        public string DisplayOrder { get; set; }
    }
}
