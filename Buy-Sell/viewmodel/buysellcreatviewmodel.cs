using Buy_Sell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buy_Sell.viewmodel
{
    public class buysellcreatviewmodel
    {
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public order Ordertype { get; set; }

        public int status { get; set; }
    }
}
