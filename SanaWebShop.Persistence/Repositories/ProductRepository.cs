using System.Collections.Generic;
using System.Linq;
using SanaWebShop.Core.Models;
using SanaWebShop.Core.RepositoriesInterfaces;

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
    }
}
