using CvCoreProject5._0.Areas.Writer.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CvCoreProject5._0.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]

    [Route("Writer/{controller}/{action}/{id?}")]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriteUser> _signInManager;

        public LoginController(SignInManager<WriteUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {

        if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("/Writer/WriterDashboard/Index");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kualncı adı veya şifre");
                }
            }
                return View();  
        }
        public async Task<IActionResult>Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Login");
        }
    }
}
