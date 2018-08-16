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
          

            return View();
        }

        public ActionResult Registerer()
        {
            return View();
        }
        public ActionResult UserRegistered(string firstName, string favoriteCoffee)
        {
            ViewBag.FirstName = firstName;
            ViewBag.FavoriteCoffee = favoriteCoffee + " coffee";
            ViewBag.DoAgain = "Would you like to add more coffee";

            HttpCookie CoffeeCookie;
            if (Request.Cookies["FavoriteCoffee"] == null)
            {
                CoffeeCookie = new HttpCookie("FavoriteCoffee");
                CoffeeCookie.Value = favoriteCoffee;
                CoffeeCookie.Expires = DateTime.UtcNow.AddYears(1);
            }
            else
            {
                CoffeeCookie = Request.Cookies["FavoriteCoffee"];
            }

            return View();
        }

        public ActionResult BuyCoffee()
        {
            var favoriteCoffee = new HttpCookie("FavoriteCoffee");

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


            ViewBag.Message = $"You want to buy " + CoffeeCounter;

            return View();
        }
        public ActionResult DeleteEverything()
        {

            var CoffeeCounterCookie = new HttpCookie("CoffeeCounterCookie");
            CoffeeCounterCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(CoffeeCounterCookie);

            var FavoriteCoffee = new HttpCookie("FavoriteCoffee");
            FavoriteCoffee.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(FavoriteCoffee);

            return RedirectToAction("Index","Home");
        }

        
    }
}