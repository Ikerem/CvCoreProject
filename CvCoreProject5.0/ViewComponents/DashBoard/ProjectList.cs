using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.DashBoard
{
    public class ProjectList:ViewComponent
    {
        PortfolioManager _portfolioManager =new PortfolioManager(new EFPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values =_portfolioManager.GetList();
            return View(values);
        }
    }
}
