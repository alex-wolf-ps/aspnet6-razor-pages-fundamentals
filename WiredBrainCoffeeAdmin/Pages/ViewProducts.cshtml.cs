using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Pages
{
    public class ViewProductsModel : PageModel
    {
        private WiredBrainContext _context;

        public List<Product> Products { get; set; }

        public ViewProductsModel(WiredBrainContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Products = _context.Products.ToList();
        }
    }
}
