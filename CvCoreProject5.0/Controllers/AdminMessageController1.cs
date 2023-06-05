using BusinesLayer.Concrete;
using DataAcsesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CvCoreProject5._0.Controllers
{
    public class AdminMessageController1 : Controller
    {
        WriterMessageMeenager _writerMessageMeenager = new WriterMessageMeenager(new EFWriterDal());
        public IActionResult ReciverBox()
        {
            string p;
            p = "admin@gmail.com";
            var values = _writerMessageMeenager.GetListReciverMessage(p);
            return View(values);
        }
        public IActionResult SenderBox()
        {
            string p;
            p = "admin@gmail.com";
            var values = _writerMessageMeenager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int p)
        {
            var values = _writerMessageMeenager.GetById(p);
            return View(values);

        }
        public IActionResult MessageDelete(int id)
        {
            var values = _writerMessageMeenager.GetById(id);
            _writerMessageMeenager.TDelete(values);
            return RedirectToAction("ReciverBox");


        }
        [HttpGet]
        public IActionResult AdminMessageAddSkill()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageAddSkill(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Contex c= new Contex();
            var Username=c.Users.Where(x=>x.Email==p.Reciver).Select(y=>y.Name +" "+y.Surname).FirstOrDefault();
            p.ReciverName = Username;
            _writerMessageMeenager.TAdd(p);
            return RedirectToAction("ReciverBox");
        }
    }
}
