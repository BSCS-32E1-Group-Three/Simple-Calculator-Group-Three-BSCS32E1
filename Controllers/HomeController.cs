using Microsoft.AspNetCore.Mvc;
using SimpleCalculator.Models;
using System.Diagnostics;

namespace SimpleCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index(string firstNumber, string secondNumber, string Cal)
        {
            double a = Convert.ToDouble(firstNumber);
            double b = Convert.ToDouble(secondNumber);
            double result = 0;

            switch (Cal)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }

            ViewBag.Result = result;
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
