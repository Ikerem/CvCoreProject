using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    public class ContecSubPlaceController1 : Controller
    {
         ContacManager _contacManager = new ContacManager(new EFContectDal());
        [HttpGet]
        public IActionResult Index()
        {

            var values = _contacManager.GetById(1);
            return View(values);
        }



        [HttpPost]
        public IActionResult Index(Contect contect)
        {
            _contacManager.TUpdate(contect);
            return RedirectToAction("Index", "ContecSubPlaceController1");

        }
    }
}
