using Microsoft.AspNetCore.Mvc;
using SoftUniLiveDemo.Models;
using System.Diagnostics;

namespace SoftUniLiveDemo.Controllers
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

        public IActionResult Socialmedias()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator(double firstNumber, string operation, double secondNumber)
        {
            string result = string.Empty;
            switch (operation)
            {
                case "+":
                    result = $"{firstNumber + secondNumber:f2}";
                    break;
                case "-":
                    result = $"{firstNumber - secondNumber:f2}";
                    break;
                case "*":
                    result = $"{firstNumber * secondNumber:f2}";
                    break;
                case "/":
                    result = $"{firstNumber / secondNumber:f2}";
                    break;
                default:
                    result = "Invalid operation";
                    break;
            }

            ViewBag.Result = result;
            return View();
        }
    }
}