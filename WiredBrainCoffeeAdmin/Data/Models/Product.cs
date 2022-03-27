using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WiredBrainCoffeeAdmin.Data
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public IFormFile Upload { get; set; }

        public string ImageFileName { get; set; }

        public DateTime Created { get; set; }
    }
}
