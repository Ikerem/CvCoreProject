using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager _skillManager = new SkillManager(new EFSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = _skillManager.GetList();
            return View(values);
        }
    }
}
