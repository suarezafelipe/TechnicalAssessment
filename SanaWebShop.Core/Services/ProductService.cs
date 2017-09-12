using System;
using System.Collections.Generic;
using SanaWebShop.Core.Models;

namespace SanaWebShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Returns the list of all products in the DB.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {
            return _unitOfWork.Products.GetAllProducts();
        }

        /// <summary>
        /// Receives a product object, validates the data, and tries to add it to the DB.
        /// Returns true if the product was created successfully, false otherwise
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool CreateProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductNumber)
                || string.IsNullOrEmpty(product.Title))
                return false;
            
            if (Math.Abs(product.Price) < 0.0001 || product.Price < 0)
                return false;
              
            bool success = _unitOfWork.Products.CreateProduct(product);

            if (!success) return false;

            _unitOfWork.Complete();
            return true;
        }
    }
}
