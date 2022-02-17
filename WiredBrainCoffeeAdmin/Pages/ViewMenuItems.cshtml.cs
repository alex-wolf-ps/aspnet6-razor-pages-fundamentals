using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Pages
{
    public class ViewMenuItemsModel : PageModel
    {
        private WiredBrainContext _context;

        public List<MenuItem> MenuItems { get; set; }

        public ViewMenuItemsModel(WiredBrainContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            MenuItems = _context.MenuItems.ToList();
        }
    }
}
