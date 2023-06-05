using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    public class ErrorPageController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
    }
}
