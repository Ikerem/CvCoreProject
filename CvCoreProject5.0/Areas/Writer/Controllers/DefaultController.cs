using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager _AnnouncementManager = new AnnouncementManager(new EFAnnouncementDal());
        public IActionResult Index()
        {
            var values = _AnnouncementManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AnnoumcementDetails(int id)
        {
           Announcement announcement = _AnnouncementManager.GetById(id);
            return View(announcement);  

        }
    }
}
