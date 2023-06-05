using BusinesLayer.Concrete;
using BusinesLayer.ValitationRules;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.Controllers
{
    public class PortfolioController1 : Controller
    {
        PortfolioManager _manager = new PortfolioManager(new EFPortfolioDal());
        public IActionResult Index()
        {
           
            var values = _manager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {

          
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
          

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);
            if (result.IsValid)
            {
                _manager.TAdd(portfolio);

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

           return RedirectToAction("Index");


        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = _manager.GetById(id);
            _manager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult PortfolioEdit(int id)
        {
          
            var values = _manager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult PortfolioEdit(Portfolio portfolio)
        {
            _manager.TUpdate(portfolio);
            return RedirectToAction("Index");

        }
    }
}
