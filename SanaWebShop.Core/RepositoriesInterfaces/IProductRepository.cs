using System.Collections.Generic;
using SanaWebShop.Core.Models;

namespace SanaWebShop.Core.RepositoriesInterfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        bool CreateProduct(Product product);
    }
}