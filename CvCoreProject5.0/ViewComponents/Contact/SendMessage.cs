using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CvCoreProject5._0.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageMenager messageMenager = new MessageMenager(new EFMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {

            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Statu = true;
        //    messageMenager.TAdd(p);
        //    return View();
        //}
    }
}
