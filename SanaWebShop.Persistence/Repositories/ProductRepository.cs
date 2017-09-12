using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SanaWebShop.Core.Models;
using SanaWebShop.Core.RepositoriesInterfaces;
using SanaWebShop.Persistence.ApplicationDbContext;

namespace SanaWebShop.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISanaWebShopDbContext _context;

        public ProductRepository(ISanaWebShopDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            var query = _context.Products.ToList();

            return query;
        }

        public bool CreateProduct(Product product)
        {
            _context.Products.Add(product);
            return true;
        }
    }
}
