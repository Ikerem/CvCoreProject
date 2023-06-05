using CvCoreProject5._0.Areas.Writer.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CvCoreProject5._0.Areas.Writer.Controllers
{
    [Area("Writer")]

    [Route("Writer/{controller}/{action}/{id?}")]
    public class ProfilController : Controller
    {

        private readonly UserManager<WriteUser> _userManager;

        public ProfilController(UserManager<WriteUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureUrl = values.ImgUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(resource);
                var ImageNam = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/UserImage/" + ImageNam;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                user.ImgUrl = ImageNam;

            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
