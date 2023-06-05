using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    public class TestimonailController1 : Controller
    {
        TestimonailManager _testimonailManager=new TestimonailManager(new EFTestimonailDal());
        
        public IActionResult Index()
        {
            var values =_testimonailManager.GetList();
            return View(values);
        }
        public IActionResult DeleteTestimonial(int id) 
        {
            var values = _testimonailManager.GetById(id);
            _testimonailManager.TDelete(values);
            return RedirectToAction("Index");
            

        }
        [HttpGet]
        public IActionResult EditTestimonial(int  id)
        {
            var values = _testimonailManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            _testimonailManager.TUpdate(testimonial);
            return RedirectToAction("Index");   

        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonailManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }

    }
}
