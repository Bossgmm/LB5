using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using FirstLab.Models;

namespace FirstLab.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "MyCafe";
            return View();
        }

        [HttpGet]
        public ViewResult DrinkForm()
        {
            ViewBag.Title = "Drinks";
            return View();
        }

        [HttpPost]
        public ViewResult DrinkForm(DrinkData drinkData)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Title = "Bill";
                ViewBag.Cost = 150;
                return View("Bill", drinkData);
            }
            else return View();
        }
    }
}