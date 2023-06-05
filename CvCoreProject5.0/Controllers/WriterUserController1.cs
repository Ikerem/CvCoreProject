using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CvCoreProject5._0.Controllers
{
    public class WriterUserController1 : Controller
    {
        WriterUserManager _writerUserManager=new WriterUserManager(new EFWriterUserDal());
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult ListUser()
        {
            var Values = JsonConvert.SerializeObject(_writerUserManager.GetList());
            return Json(Values);
        }
        [HttpPost]
        public IActionResult AddUser(WriteUser p)
        {
            _writerUserManager.Insert(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        
    }

}
