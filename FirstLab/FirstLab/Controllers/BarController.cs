using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using FirstLab.Models;

namespace FirstLab.Controllers
{
    public class BarController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Bar";
            return View();
        }
        [HttpGet]
        public ViewResult BarForm()
        {
            ViewBag.Title = "Drinks";
            return View();
        }
        [HttpPost]
        public ViewResult BarForm(BarData BarData)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Title = "Bill";
                ViewBag.Cost = 150;
                return View("Bill", BarData);
            }
            else return View();
        }
    }
}