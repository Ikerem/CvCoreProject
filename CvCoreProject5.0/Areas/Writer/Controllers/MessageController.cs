using BusinesLayer.Concrete;
using DataAcsesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace CvCoreProject5._0.Areas.Writer.Controllers
{
    [Area("Writer")]

    [Route("Writer/{controller}/{action}/{id?}")]
    

    public class MessageController : Controller
    {
        WriterMessageMeenager _WriterMessageMeenager = new WriterMessageMeenager(new EFWriterDal());
        private readonly UserManager<WriteUser> _userManager;

        public MessageController(UserManager<WriteUser> userManager)
        {
            _userManager = userManager;
        }
      

        public async Task<IActionResult> ReciverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = _WriterMessageMeenager.GetListReciverMessage(p);
            return View(messagelist);
        }
     
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = _WriterMessageMeenager.GetListSenderMessage(p);
            return View(messagelist);
        }
     
        public IActionResult MessagDetails(int id)
        {
            WriterMessage writerMessage = _WriterMessageMeenager.GetById(id);
            return View(writerMessage);

        }
       
        public IActionResult ReciverMessagDetails(int id)
        {
            WriterMessage writerMessage = _WriterMessageMeenager.GetById(id);
            return View(writerMessage);

        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Contex c = new Contex();
            var usernamesurname = c.Users.Where(x => x.Email == p.Reciver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReciverName = usernamesurname;
            _WriterMessageMeenager.TAdd(p);
            return RedirectToAction("SenderMessage");

        }
    }
}
