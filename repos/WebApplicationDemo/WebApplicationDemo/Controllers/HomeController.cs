using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        private CompanyContext context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,CompanyContext cC)
        {
            _logger = logger;
            context = cC;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }
        public string CreateInformation()
        {
            var info = new Information()
            {
                Name = "Eswaran",
                License = "xxxyz",
                Revenue = 10000,
                Established=Convert.ToDateTime("2024/08/01")
            };
            var info1 = new Information()
            {
                Name = "Aravindan",
                License = "zion",
                Revenue = 15000,
                Established = Convert.ToDateTime("2024/08/01")
            };


            context.Entry(info).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            context.Entry(info1).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            context.SaveChanges();
            return "Added Successfully";

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
