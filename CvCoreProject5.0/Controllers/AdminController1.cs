using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    public class AdminController1 : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartlNavBar()
        {
            return PartlNavBar();

        }
        public PartialViewResult PartialHeader()
        {
            return PartlNavBar();

        }
        public PartialViewResult PartialScript()
        {
            return PartlNavBar();

        }
        public PartialViewResult NavigationPartial()
        {
            return PartlNavBar();

        }
        public PartialViewResult NewSideBar()
        {
            return PartialView();
        }
    }
}
