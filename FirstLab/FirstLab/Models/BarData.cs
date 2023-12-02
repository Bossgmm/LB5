using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstLab.Models
{
    public class BarData
    {
        public BarType BarType { get; set; }
        public bool ICE { get; set;}
    }
    public enum BarType
    {
        Tequila,
        Whiskey,
        Rom
    }
}
