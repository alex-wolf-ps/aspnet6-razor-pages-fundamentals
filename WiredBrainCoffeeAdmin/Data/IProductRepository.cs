namespace WiredBrainCoffeeAdmin.Data
{
    public interface IProductRepository
    {
        public void Add(Product product);
        public void Update(Product product);
        public Product GetById(int id);
        public List<Product> GetAll();
        public void Delete(int id);
    }
}
