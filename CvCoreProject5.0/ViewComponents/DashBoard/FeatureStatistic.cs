using BusinesLayer.Concrete;
using DataAcsesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvCoreProject5._0.ViewComponents.DashBoard
{
    public class FeatureStatistic:ViewComponent

    {
        Contex c =new Contex();
      
        public IViewComponentResult Invoke()
        {

            ViewBag.d1 = c.Skills.Count();
            ViewBag.d2 = c.Messages.Where(x=>x.Statu==false) .Count();
            ViewBag.d3 = c.Messages.Where(x => x.Statu == true).Count();
            ViewBag.d4 = c.Experinces.Count();
            //var values = _contacManager.GetList();

            return View();
        }
    }
}
