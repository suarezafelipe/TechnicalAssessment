using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SanaWebShop.Core;
using SanaWebShop.Core.RepositoriesInterfaces;
using SanaWebShop.Core.Services;
using SanaWebShop.Presentation.Controllers;

namespace SanaWebShop.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private readonly HomeController _homeController;

        public HomeControllerTest()
        {
            var mockProductRepository = new Mock<IProductRepository>();
            var mockProductService = new Mock<IProductService>();

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.SetupGet(x => x.Products).Returns(mockProductRepository.Object);
            
            _homeController = new HomeController(mockProductService.Object);
        }

        // TODO: Create the tests for the Controller
        
    }
}
