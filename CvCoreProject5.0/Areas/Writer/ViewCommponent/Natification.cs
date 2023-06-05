using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CvCoreProject5._0.Areas.Writer.ViewCommponent
{
    public class Natification:ViewComponent
    {
        AnnouncementManager AnnouncementManager = new AnnouncementManager(new EFAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = AnnouncementManager.GetList().Take(5).ToList();
            return View();
        }
    }
}
