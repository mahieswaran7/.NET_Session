using EFCoreTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace EFCoreTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]

        public IActionResult Index(string username, string password)
        {
            if ((username != "secret") || (password != "secret"))
            {
                return View((object)"Login Failed");
            }
            Console.WriteLine(username + " " + password);
            var accesstoken = GenerateJSONWebToken();
            setJWTCookie(accesstoken);

            return RedirectToAction("Index","Employee");


        }

        private string GenerateJSONWebToken()
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MynameisJamesBond0007_MynameisJamesBond007"));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);


            var token = new JwtSecurityToken(
                issuer: "https://www.yogihosting.com",
                audience: "dotnetclient",
                expires: DateTime.Now.AddHours(3),
                signingCredentials: credentials


                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public void setJWTCookie(string token)
        {
            var cookieoptions =
                 new CookieOptions()
                 {
                     HttpOnly = true,
                     Expires = DateTime.Now.AddHours(3)
                 };
            Response.Cookies.Append("jwtcookie", token, cookieoptions);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
