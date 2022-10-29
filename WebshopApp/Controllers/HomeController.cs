using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebshopApp.Models;

namespace WebshopApp.Controllers
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
            _logger.Log(LogLevel.Debug, "HomeController.Index()");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.Log(LogLevel.Debug, "HomeController.Privacy()");
            return View();
        }

        public IActionResult MyView()
        {
            _logger.Log(LogLevel.Debug, "HomeController.MyView()");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.Log(LogLevel.Debug, "HomeController.Error()");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}