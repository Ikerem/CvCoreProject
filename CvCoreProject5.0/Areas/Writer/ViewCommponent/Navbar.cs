using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CvCoreProject5._0.Areas.Writer.ViewCommponent
{
    public class Navbar:ViewComponent
    {
        private readonly UserManager<WriteUser> _userManager;

        public Navbar(UserManager<WriteUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task< IViewComponentResult > InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.g1=values.ImgUrl;
            return View();
        }
    }
}
