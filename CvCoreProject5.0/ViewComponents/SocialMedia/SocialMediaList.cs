using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.SocialMedia
{
    public class SocialMediaList : ViewComponent
    {
        SocialMediaManager _mediaManager=new SocialMediaManager(new EFSocialMedaiDal());
        public IViewComponentResult Invoke()
        {
            var values = _mediaManager.GetList();

            return View(values);
        }
    }
}
