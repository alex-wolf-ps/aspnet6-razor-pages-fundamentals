using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.ViewComponents
{
    public class MenuItemsList : ViewComponent
    {
        private readonly WiredBrainContext _context;

        public MenuItemsList(WiredBrainContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int itemCount)
        {
            return View(_context.MenuItems.Take(itemCount).ToList());
        }
    }
}
