using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(decimal num1, decimal num2, string operation)
        {
            decimal result = 0;

            switch (operation)
            {
                case "add":
                    result = num1 + num2;
                    break;
                case "subtract":
                    result = num1 - num2;
                    break;
                case "multiply":
                    result = num1 * num2;
                    break;
                case "divide":
                    result = num1 / num2;
                    break;
            }

            ViewBag.Result = result;

            return View();
        }
    }
}

