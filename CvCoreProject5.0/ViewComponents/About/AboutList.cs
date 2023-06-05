using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager _aboutManager=new AboutManager(new EFAboutDal());
        public IViewComponentResult Invoke()
        {
            var values= _aboutManager.GetList();
            return View(values);
        }

    }
}
