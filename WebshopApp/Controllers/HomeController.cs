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

        public IActionResult ShowQuestion()
        {
            _logger.Log(LogLevel.Debug, "HomeController.ShowQuestion()");
            return View();
        }

        public IActionResult CheckResult(string result, string operanda, string operandb)
        {
            _logger.Log(LogLevel.Debug, $"HomeController.CheckResul(result={result}, OperandA={operanda}, OperandB={operandb})");

            string description;


            int a;
            int b;
            int r;
            int.TryParse(operanda, out a);
            int.TryParse(operandb, out b);
            int.TryParse(result, out r);

            if (a + b == r)
            {
                description = "Jeps, det er rigtigt";
            }
            else
            {
                description = "Nej din skovl, det er forkert";
            }

            var resultModel = new CalcData()
            {
                OperandA = a,
                OperandB = b,
                Result = r,
                Description = description
            };

            return View(resultModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.Log(LogLevel.Debug, "HomeController.Error()");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}