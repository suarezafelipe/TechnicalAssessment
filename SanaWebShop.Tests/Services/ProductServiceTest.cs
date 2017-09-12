using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SanaWebShop.Core;
using SanaWebShop.Core.Models;
using SanaWebShop.Core.RepositoriesInterfaces;
using SanaWebShop.Core.Services;

namespace SanaWebShop.Tests.Services
{
    [TestClass]
    public class ProductServiceTest
    {
        private readonly ProductService _productService;

        public ProductServiceTest()
        {
            var mockProductRepository = new Mock<IProductRepository>();

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.SetupGet(x => x.Products).Returns(mockProductRepository.Object);

            _productService = new ProductService(mockUoW.Object);
        }

        [TestMethod]
        public void CreateProduct_EmptyName_ShouldReturnFalse()
        {
            var product = new Product
            {
                ProductNumber = "SKU21432",
                Price = 12
            };

            var result = _productService.CreateProduct(product);

            result.Should().Be(false);
        }

        [TestMethod]
        public void CreateProduct_EmptyProductNumber_ShouldReturnFalse()
        {
            var product = new Product
            {
                Price = 12,
                Title = "Tablet Surface"
            };

            var result = _productService.CreateProduct(product);

            result.Should().Be(false);
        }

        [TestMethod]
        public void CreateProduct_EmptyPrice_ShouldReturnFalse()
        {
            var product = new Product
            {
                Title = "Surface Pro",
                Price = 12
            };

            var result = _productService.CreateProduct(product);

            result.Should().Be(false);
        }
      

        // TODO Complete test cases

    }
}
