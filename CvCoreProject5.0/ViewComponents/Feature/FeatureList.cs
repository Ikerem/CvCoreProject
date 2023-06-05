using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager =new FeatureManager(new EFfeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.GetList();
            return View(values);
        }

    }
}
