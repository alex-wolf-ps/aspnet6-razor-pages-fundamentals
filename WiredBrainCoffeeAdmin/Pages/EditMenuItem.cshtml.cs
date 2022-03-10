using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Pages
{
    public class EditMenuItemModel : PageModel
    {
        private WiredBrainContext _context;
        private IWebHostEnvironment _environment;

        public List<MenuItem> MenuItems { get; set; }

        public EditMenuItemModel(WiredBrainContext context,
            IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [BindProperty]
        public MenuItem MenuItem { get; set; }

        [FromRoute]
        public int Id { get; set; }

        public void OnGet()
        {
            if (Id != 0)
            {
                MenuItem = _context.MenuItems.FirstOrDefault(x => x.Id == Id);
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var savedItem = _context.MenuItems.FirstOrDefault(x => x.Id == Id);

                savedItem.Name = MenuItem.Name;
                savedItem.Description = MenuItem.Description;
                savedItem.ShortDescription = MenuItem.ShortDescription;
                savedItem.Category = MenuItem.Category;
                savedItem.Price = MenuItem.Price;
                savedItem.ImageFile = MenuItem.Upload is not null ? MenuItem.Upload.FileName : savedItem.ImageFile;
                _context.SaveChanges();

                if (MenuItem.Upload != null)
                {
                    var file = Path.Combine(_environment.ContentRootPath, "wwwroot/images/menu", MenuItem.Upload.FileName);
                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        await MenuItem.Upload.CopyToAsync(fileStream);
                    }
                }

                return RedirectToPage("ViewMenuItems");
            }

            return Page();
        }
    }
}
