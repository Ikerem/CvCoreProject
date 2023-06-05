using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ExperinceController1 : Controller
    {
        EXperinceManager experinceManager = new EXperinceManager(new EFExperinceDal());
        public IActionResult Index()
        {
         
            var values = experinceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperince()
        {
    
            return View();  

        }
        [HttpPost]
        public IActionResult AddExperince(Experince experince)
        {
            
            experinceManager.TAdd(experince);

            return RedirectToAction("Index");

        }
        public IActionResult DeleteExperince(int id)
        {
            var values = experinceManager.GetById(id);
            experinceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperince(int id)
        {
            
            var values = experinceManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperince(Experince experince)
        {
            experinceManager.TUpdate(experince);
            return RedirectToAction("Index");

        }
    }
}
