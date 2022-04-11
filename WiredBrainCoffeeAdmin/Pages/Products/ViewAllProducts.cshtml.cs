using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Pages.Products
{
    public class ViewAllProductsModel : PageModel
    {
        public List<Product> Products { get; set; }

        private IProductRepository productRepo;

        public ViewAllProductsModel(IProductRepository productRepository)
        {
            this.productRepo = productRepository;
        }

        public void OnGet()
        {
            Products = this.productRepo.GetAll();
        }
    }
}
