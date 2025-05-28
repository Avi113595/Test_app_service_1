using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Diagnostics;
using Test_app_service.Models;

namespace Test_app_service.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = _configuration["Greetings"];
            return View();
        }

        public IActionResult Privacy()
        {
            throw new Exception("This is a test exception to demonstrate error handling in the application.");
            //return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
