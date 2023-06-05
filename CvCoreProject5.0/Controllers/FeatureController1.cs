using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    public class FeatureController1 : Controller
    {
        FeatureManager _FeatureManager = new FeatureManager(new EFfeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
           
            var values = _FeatureManager.GetById(1);
            return View(values);
        }
      


        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            _FeatureManager.TUpdate(feature);
            return RedirectToAction("Index", "FeatureController1");

        }
    }
}
