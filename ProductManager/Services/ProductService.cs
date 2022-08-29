using ProductManager.Models;

namespace ProductManager.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            this._context = context;
        }
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}