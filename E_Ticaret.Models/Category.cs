using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Ticaret.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Dislplay Order")]
        [Range(1,100)]
        public string DisplayOrder { get; set; }
    }
}
