using Microsoft.AspNetCore.Mvc;
using SecurityDemo.Models;
using System.Diagnostics;

namespace SecurityDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViweBagExample()
        {
            ViewBag.CurrentDateTime = DateTime.Now;
            ViewBag.CurrentYear = DateTime.Now.Year;
            return View();
        }

        public IActionResult TempDataExample()
        {
            TempData["CurrentDateTime"] = DateTime.Now;
            TempData["CurrentYear"] = DateTime.Now.Year;
            return RedirectToAction("Index");
        }

        public IActionResult SessionByExample()
        {
            HttpContext.Session.SetString("CurrentDateTime", DateTime.Now.ToString());
            HttpContext.Session.SetString("CurrentYear", DateTime.Now.Year.ToString());
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
