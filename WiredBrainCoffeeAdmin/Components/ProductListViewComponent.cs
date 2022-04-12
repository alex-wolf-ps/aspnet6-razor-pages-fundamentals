using Microsoft.AspNetCore.Mvc;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Components
{
    public class ProductListViewComponent : ViewComponent
    {
        private IProductRepository productRepo;

        public ProductListViewComponent(IProductRepository productRepository)
        {
            this.productRepo = productRepository;
        }

        public IViewComponentResult Invoke(int count)
        {
            var items = productRepo.GetAll();
            if(count > 0)
            {
                return View(items.Take(count).ToList());
            }
            
            return View(items);
        }
    }
}
