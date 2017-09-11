using System.Collections.Generic;
using SanaWebShop.Core.Models;

namespace SanaWebShop.Core.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
    }
}