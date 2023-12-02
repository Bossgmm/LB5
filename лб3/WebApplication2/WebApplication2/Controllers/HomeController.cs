using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using Ninject;
namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;
        private Product[] products = 
        {
            new Product {Name = "Kayak",Categoty = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket",Categoty = "Watersports", Price =  48.95M},
            new Product {Name = "Soccer ball",Categoty = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag",Categoty = "Soccer", Price =  34.95M}
        };
        public HomeController(IValueCalculator calcParam, IValueCalculator calc2)
        {
            calc = calcParam;
        }
        public ActionResult Index() 
        {
            ShoppingCart cart = new ShoppingCart(calc){ Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);

        }
    }
}