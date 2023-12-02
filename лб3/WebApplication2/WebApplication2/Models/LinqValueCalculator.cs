using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebApplication2.Models.Discount;

namespace WebApplication2.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discounter;
        private static int counter = 0;
        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            discounter = discountParam;
            System.Diagnostics.Debug.WriteLine(string.Format("Instane {0} created", ++counter));
        }
        public decimal ValueProducts(IEnumerable<Product> Products)
        {
            return discounter.ApplyDiscount(Products.Sum(p =>p.Price));
        }
    }
}