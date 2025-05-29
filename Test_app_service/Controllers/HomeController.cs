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
            //throw new Exception("This is a test exception to demonstrate error handling in the application.");
            return View();
        }

        [Route("error")]
        public IActionResult Error()
        {
            return View();
        }
        [Route("healthcheck/staging")]
        public IActionResult HealthCheck_staging()
        {
            return Ok("The application is running smoothly.");
        }
    }
}
