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
            ViewBag.Message = "Welcome to the coffee shop.";

            

            return View();
        }

        public ActionResult Contact()
        {
            int Counter = 0;
          HttpCookie cookie;
            if (Request.Cookies["CounterCookie"]==null)
            {
                cookie = new HttpCookie("CounterCookie");
                cookie.Value = "0";
                cookie.Expires = DateTime.UtcNow.AddYears(1);
            }
            else
            {
                cookie = Request.Cookies["CounterCookie"];
            }

            Counter = int.Parse(cookie.Value);
            Counter += 1;
            cookie.Value = Counter.ToString();
            Response.Cookies.Add(cookie);
            ViewBag.Message = $"Counter = (Counter)";

            return View();
        }

        public ActionResult Registerer()
        {
            return View();
        }
        public ActionResult UserRegistered(string firstName)
        {
            ViewBag.FirstName = firstName;
            ViewBag.DoAgain = "Would you like to add more coffee or checkout and leave?";


            
            
            return View();
        }

        public ActionResult BuyCoffee()
        {
            int CoffeeCounter = 0;
            HttpCookie CoffeeCookie;
            if (Request.Cookies["CoffeeCounterCookie"] == null)
            {
                CoffeeCookie = new HttpCookie("CoffeeCounterCookie");
                CoffeeCookie.Value = "0";
                CoffeeCookie.Expires = DateTime.UtcNow.AddYears(1);
            }
            else
            {
                CoffeeCookie = Request.Cookies["CoffeeCounterCookie"];
            }

            CoffeeCounter = int.Parse(CoffeeCookie.Value);
            CoffeeCounter += 1;
            CoffeeCookie.Value = CoffeeCounter.ToString();
            Response.Cookies.Add(CoffeeCookie);
            ViewBag.Message = $"Counter = (CoffeeCookie)";

            return View();
        }

        
    }
}