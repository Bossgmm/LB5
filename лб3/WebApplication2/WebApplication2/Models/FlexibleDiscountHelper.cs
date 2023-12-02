using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebApplication2.Models.Discount;

namespace WebApplication2.Models
{
    public class FlexibleDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            decimal discount = totalParam > 100 ? 70 : 25;
            return (totalParam - (discount / 100m * totalParam));
        }
    }
}