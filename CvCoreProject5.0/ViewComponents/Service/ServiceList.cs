using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager _serviceManager = new ServiceManager(new EFServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = _serviceManager.GetList();
            return View(values);
        }


    }
}
