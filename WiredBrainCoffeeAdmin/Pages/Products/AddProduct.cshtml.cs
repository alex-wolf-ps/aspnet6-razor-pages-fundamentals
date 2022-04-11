using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Pages.Products
{
    public class AddProductModel : PageModel
    {
        private IProductRepository productRepo;
        private IWebHostEnvironment webEnv;

        public AddProductModel(IProductRepository productRepository,
            IWebHostEnvironment environment)
        {
            this.productRepo = productRepository;
            this.webEnv = environment;
        }

        [BindProperty]
        public Product NewProduct { get; set; }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }

            if (NewProduct.Upload is not null)
            {
                NewProduct.ImageFileName = NewProduct.Upload.FileName;

                var file = Path.Combine(webEnv.ContentRootPath,
                    "wwwroot/images/menu", NewProduct.Upload.FileName);
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    await NewProduct.Upload.CopyToAsync(fileStream);
                }
            }

            NewProduct.Created = DateTime.Now;
            this.productRepo.Add(NewProduct);

            return RedirectToPage("ViewAllProducts");
        }
    }
}
