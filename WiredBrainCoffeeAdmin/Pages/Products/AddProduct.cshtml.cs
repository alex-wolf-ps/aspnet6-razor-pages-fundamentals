using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Pages.Products
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public Product NewProduct { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Save product to database
                var productName = NewProduct.Name;

                return RedirectToPage("ViewAllProducts");
            }

            return Page();
        }
    }
}
