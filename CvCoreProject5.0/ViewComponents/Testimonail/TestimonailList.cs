using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.Testimonail
{
    public class TestimonailList:ViewComponent
    {
        TestimonailManager _testimonailManager= new TestimonailManager(new EFTestimonailDal());
        public IViewComponentResult Invoke()
        {
            var values = _testimonailManager.GetList();
            return View(values);
        }
    }
}
