using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FirstApp.Controllers
{
    public class CalculateController : Controller
    {

        public IActionResult Info()
        {
            Person person = new Person();
            person.name = "Eswaran";
            person.basicsalary = 10000;
            person.age = 21;
            return View(person);
        }
        public IActionResult Index()
        {
            ViewBag.Heading = "Hello Everyone";
            return View();
        }

        public IActionResult Greeting()
        {
            return View();
        }




    }
}
