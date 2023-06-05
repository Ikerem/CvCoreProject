using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace CvCoreProject5._0.Controllers
{
    public class SocialMedaiController1 : Controller
    {
        SocialMediaManager _SocialMediaManager =new SocialMediaManager(new EFSocialMedaiDal());
        public IActionResult Index()
        {
            var values =_SocialMediaManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedai()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedai(SocialMedia socialMedia)
        {
            _SocialMediaManager.TAdd(socialMedia);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedai(int id)
        {
            var values=_SocialMediaManager.GetById(id);
            _SocialMediaManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var values = _SocialMediaManager.GetById(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia p)
        {
            _SocialMediaManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
