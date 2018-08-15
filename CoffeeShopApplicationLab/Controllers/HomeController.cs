﻿using System;
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
          /*  HttpCookie cookie;
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
            ViewBag.Message = $"Counter = (Counter)";*/

            return View();
        }

        public ActionResult Registerer()
        {
            return View();
        }
        public ActionResult UserRegistered(string firstName)
        {
            ViewBag.FirstName = firstName;
            return View();
        }

        
    }
}