using CvCoreProject5._0.Areas.Writer.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Threading.Tasks;

namespace CvCoreProject5._0.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]

    [Route("Writer/{controller}/{action}/{id?}")]
    public class RegistarController : Controller
    {
        private readonly UserManager<WriteUser> _userManager;

        public RegistarController(UserManager<WriteUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                WriteUser w = new WriteUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Mail,
                    UserName = p.UserName,
                    ImgUrl = p.ImageUrl
                };
                if (p.Password==p.ConfirmPassword)
                {

                var result = await _userManager.CreateAsync(w, p.Password);
              

                if (result.Succeeded  )
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);

                    }
                }
                }

            }

            return View();
        }
        //Kağn şifre:Hanedan1975*
    }
}
