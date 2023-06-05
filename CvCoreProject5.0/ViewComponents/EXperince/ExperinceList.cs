using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.EXperince
{
    public class ExperinceList:ViewComponent
    {
        EXperinceManager _EXperinceManager=new EXperinceManager(new EFExperinceDal());
        public IViewComponentResult Invoke()
        {
            var values = _EXperinceManager.GetList();
            return View(values);
        }
    }
}
