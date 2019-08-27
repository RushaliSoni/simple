using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Buy_Sell.Models
{
    public class buysellitem
    {
        
        public int  Id { get; set; }
        [Required, Display(Name= "Quantity")]
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public order Ordertype { get; set; }


    }
    public enum order
    {
         buy=1,
         sell=2
    }
}
