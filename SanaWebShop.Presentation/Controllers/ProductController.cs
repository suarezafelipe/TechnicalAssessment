using System.Collections.Generic;
using System.Web.Mvc;
using SanaWebShop.Core.Models;
using SanaWebShop.Core.Services;
using SanaWebShop.Presentation.ViewModels;

namespace SanaWebShop.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult List()
        {
            List<Product> products = _productService.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(ProductViewModel product)
        {
            string response = "";
            bool success = _productService.CreateProduct(new Product
            {
                Price = product.Price,
                ProductNumber = product.ProductNumber,
                Title = product.Name
            });

            response = success 
                ? "Product created successfully!" 
                : "There was an error trying to create the product. Please complete all the fields";

            return Json(new { Message = response});
        }

    }
}
