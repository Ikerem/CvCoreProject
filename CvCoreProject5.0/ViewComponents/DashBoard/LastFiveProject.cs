using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.DashBoard
{
    public class LastFiveProject:ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
          
            return View();
        }
    }
}
