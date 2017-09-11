using System.Collections.Generic;
using System.Web.Mvc;
using SanaWebShop.Core.Models;
using SanaWebShop.Core.RepositoriesInterfaces;
using SanaWebShop.Core.Services;
using SanaWebShop.Persistence;

namespace SanaWebShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            List<Product> products = _productService.GetAllProducts();
            return View(products);
        }
        
    }
}