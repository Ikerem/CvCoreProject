using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CvCoreProject5._0.ViewComponents.DashBoard
{
    public class MessageList:ViewComponent
    { 
        MessageMenager _menager=new MessageMenager(new EFMessageDal());
       
        public IViewComponentResult Invoke()
        {
            var values =_menager.GetList().Take(5).ToList();
            return View(values);
        }
    }
}
