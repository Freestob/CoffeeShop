using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShopApplicationLab.Models;

namespace CoffeeShopApplicationLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Register(Registerer model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(UserSuccess), new { FirstName = model.FirstName, });
            }

            return View(model);
        }

        public ActionResult UserSuccess(string firstName)
        {
            ViewBag.FirstName = firstName;
            return View();
        }
    }
}