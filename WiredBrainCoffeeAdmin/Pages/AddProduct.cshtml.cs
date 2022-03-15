using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Pages
{
    public class AddProductModel : PageModel
    {
        private WiredBrainContext _context;
        private IWebHostEnvironment _environment;

        public List<Product> Products { get; set; }

        public AddProductModel(WiredBrainContext context,
            IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [BindProperty]
        public Product Product { get; set; }

        [FromRoute]
        public int Id { get; set; }

        public void OnGet()
        {
            if (Id != 0)
            {
                Product = _context.Products.FirstOrDefault(x => x.Id == Id);
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if(Id == 0)
                {
                    Product.ImageFile = Product.Upload.FileName;
                    Product.Category = Product.Category;
                    _context.Products.Add(Product);
                    _context.SaveChanges();

                    var file = Path.Combine(_environment.ContentRootPath, "wwwroot/images/menu", Product.Upload.FileName);
                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        await Product.Upload.CopyToAsync(fileStream);
                    }
                } 
                else
                {
                    var savedItem = _context.Products.FirstOrDefault(x => x.Id == Id);

                    savedItem.Name = Product.Name;
                    savedItem.Description = Product.Description;
                    savedItem.ShortDescription = Product.ShortDescription;
                    savedItem.Category = Product.Category;
                    savedItem.Price = Product.Price;
                    savedItem.ImageFile = Product.Upload is not null ? Product.Upload.FileName : savedItem.ImageFile;
                    _context.SaveChanges();

                    if (Product.Upload != null)
                    {
                        var file = Path.Combine(_environment.ContentRootPath, "wwwroot/images/menu", Product.Upload.FileName);
                        using (var fileStream = new FileStream(file, FileMode.Create))
                        {
                            await Product.Upload.CopyToAsync(fileStream);
                        }
                    }
                }

                return RedirectToPage("ViewProducts");
            }

            return Page();
        }
    }
}
