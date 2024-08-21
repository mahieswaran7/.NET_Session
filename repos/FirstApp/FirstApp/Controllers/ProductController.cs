using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()

        {
           Product product = new Product();
            product.Name = "Meera Shampoo";
            product.Price = 200;
            product.Description = "Good Shampoo";
            return View(product);
        }
    }
}
