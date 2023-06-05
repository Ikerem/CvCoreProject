using DataAcsesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvCoreProject5._0.ViewComponents.DashBoard
{
    public class StatistickDashboard2:ViewComponent
    {
        Contex c=new Contex();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Portfolios.Count();
            ViewBag.v2 = c.Skills.Count();
            ViewBag.v3 = c.Services.Count();

            return View();
        }
    }
}
