using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContacManager _contacManager = new ContacManager(new EFContectDal());
        public IViewComponentResult Invoke()
        {
            var values = _contacManager.GetList();
          
            return View(values);
        }
    }
}
