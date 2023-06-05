using DataAcsesLayer.Concrete;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace CvCoreProject5._0.Areas.Writer.Controllers
{
  
        [Area("Writer")]
        public class WriterDashboardController : Controller
        {
            private readonly UserManager<WriteUser> _userManager;

        public WriterDashboardController(UserManager<WriteUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
            {
                var values = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.d1 = values.Name + " " + values.Surname;
            //Weather Api
            string api = "9d9c1e55b9df1077a213379ef5422435";
            string conntetion = "http://api.openweathermap.org/data/2.5/weather?q=marmaris&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(conntetion);
            ViewBag.v1 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //istatistikler
            Contex c = new Contex();
            ViewBag.d2 = c.WriterMessages.Where(x=>x.Reciver==values.Email).Count();
            ViewBag.d3 = c.Announcements.Count();
            ViewBag.d4 = c.Users.Count();
            ViewBag.d5 = c.Skills.Count();


                return View();
            }
        }
    }

