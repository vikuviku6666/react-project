using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace react_project.Dtos.Product
{
    public class AddProductDto
    {
      

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}