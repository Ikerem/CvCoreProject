using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    public class AboutController1 : Controller
    {
        AboutManager _aboutManager = new AboutManager(new EFAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
          
            var values = _aboutManager.GetById(1);
            return View(values);
        }



        [HttpPost]
        public IActionResult Index(About about)
        {
            _aboutManager.TUpdate(about);
            return RedirectToAction("Index", "AboutController1");

        }
    }
}
