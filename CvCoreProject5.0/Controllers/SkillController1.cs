using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    public class SkillController1 : Controller
    {
        SkillManager skillManager = new SkillManager(new EFSkillDal());
        public IActionResult Index()

        {
         
            var values = skillManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
           
            return View();   
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.GetById(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
         
            var values = skillManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
          skillManager.TUpdate(skill);
            return RedirectToAction("Index");
            
        }

    }
}
