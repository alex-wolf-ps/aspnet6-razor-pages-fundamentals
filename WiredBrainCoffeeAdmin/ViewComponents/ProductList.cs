using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.ViewComponents
{
    public class ProductList : ViewComponent
    {
        private readonly WiredBrainContext _context;

        public ProductList(WiredBrainContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int itemCount)
        {
            if(itemCount != 0)
            {
                return View(_context.Products.Take(itemCount).ToList());
            }

            return View(_context.Products.ToList());
        }
    }
}
