using Microsoft.AspNetCore.Diagnostics;
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

            
            Random random = new Random();
            
            CalcData calcData = new CalcData()
            {
                OperandA = random.Next(1, 10),
                OperandB = random.Next(1, 10),
                Result = 0,
                Description = ""
            };

            return View(calcData);
        }

        [HttpPost]
        public IActionResult CheckResult(CalcData calcData)
        {
            _logger.LogDebug($"HomeController.CheckResul(result={calcData.Result}, OperandA={calcData.OperandA}, OperandB={calcData.OperandB})");


            string input = "Hallo";
            string output = "";
            foreach (char c in input)
            {
                output = c + output;
            }
            _logger.LogDebug($"HomeController.CheckResul(Input={input}, Output={output})");


            int error = calcData.OperandA / calcData.Result;

            if (calcData.OperandA + calcData.OperandB == calcData.Result)
            {
                calcData.Description = "Jeps, det er rigtigt";
            }
            else
            {
                calcData.Description = "Nej din skovl, det er forkert";
            }

            return View(calcData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (exceptionHandlerPathFeature != null)
            {
                _logger.LogError(exceptionHandlerPathFeature.Error, "Shit Happens (With Exception)");
            }
            else
            {
                _logger.Log(LogLevel.Error, "Shit Happens...");
            }

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}