using System.Collections.Generic;
using SanaWebShop.Core.Models;
using SanaWebShop.Core.RepositoriesInterfaces;

namespace SanaWebShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Product> GetAllProducts()
        {
            return _unitOfWork.Products.GetAllProducts();
        }

        public bool CreateProduct(Product product)
        {
            bool backEndValidations = true;

            if (!backEndValidations)
                return false;

            _unitOfWork.Products.CreateProduct(product);
            _unitOfWork.Complete();

            return true;

        }
    }
}
