using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudFucntional.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(15)]
        [Description("Product name")]
        public string? Name { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        [Description("Product description")]
        public string? Description { get; set; }

        [Required]
        public double Price { get; set;}
    }
}