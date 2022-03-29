using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WiredBrainCoffeeAdmin.Data
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [MaxLength(30)]
        [Required]
        public string ShortDescription { get; set; }
        [MinLength(20)]
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Category { get; set; }

        public IFormFile Upload { get; set; }

        public string ImageFileName { get; set; }

        public DateTime Created { get; set; }
    }
}
