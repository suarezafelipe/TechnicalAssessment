using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SanaWebShop.Core.Models;
using SanaWebShop.Core.RepositoriesInterfaces;
using SanaWebShop.Persistence;

namespace SanaWebShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _repository;

        public HomeController(IProductRepository repository, ISanaWebShopDbContext context)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            List<Product> products = _repository.GetAllProducts();
            return View(products);
        }
        
    }
}