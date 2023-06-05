
using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CvCoreProject5._0.Controllers
{
    public class Experince2Controller1 : Controller
    {
        EXperinceManager  _eXperinceManager =new EXperinceManager(new EFExperinceDal());
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult ListExperince()
        {
            var Values = JsonConvert.SerializeObject(_eXperinceManager.GetList());
            return Json(Values);
        }
        [HttpPost]
        public IActionResult AddExperince(Experince p)
        {
            _eXperinceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
