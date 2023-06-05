using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CvCoreProject5._0.Controllers
{
	[AllowAnonymous]
	public class DefaultController1 : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SendMessage(Message p)
		{
            MessageMenager messageMenager = new MessageMenager(new EFMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Statu = true;
            messageMenager.TAdd(p);
            return PartialView();
		}

    }
}
