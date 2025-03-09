using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUD_Razor.Models
{
    public class Category
    {
        [Key] // Primary Key
        public int Id { get; set; }
        [Required] // Required field
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")] // Display name for the field
        [Range(1, 100, ErrorMessage = "Display Order Must be between, 1-100")]
        public int DisplayOrder { get; set; }
    }
}
