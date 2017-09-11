using System.Collections.Generic;
using SanaWebShop.Core.Models;
using SanaWebShop.Core.RepositoriesInterfaces;

namespace SanaWebShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
