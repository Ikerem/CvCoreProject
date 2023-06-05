using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    public class ServiceController1 : Controller
    {
        ServiceManager _serviceManager = new ServiceManager(new EFServiceDal());
        
        
        public IActionResult Index()
        {
        
            
            var values = _serviceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
         
            return View();

        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {

            _serviceManager.TAdd(service);

            return RedirectToAction("Index");

        }
        public IActionResult DeleteService(int id)
        {
            var values = _serviceManager.GetById(id);
            _serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
           
            var values = _serviceManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            _serviceManager.TUpdate(service);
            return RedirectToAction("Index");

        }




    }
}
