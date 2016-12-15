using propertyTaxFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace propertyTaxFinal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Calculate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Calculate(PropertyTax Ca)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirm", Ca);
            }
            else
            {
                return View(Ca);
            }
        }

        public ActionResult Confirm(PropertyTax Ca)
        {
            return View(Ca);
        }
    }
}