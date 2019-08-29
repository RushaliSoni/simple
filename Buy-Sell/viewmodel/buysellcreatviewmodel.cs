using Buy_Sell.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Buy_Sell.viewmodel
{
    public class buysellcreatviewmodel
    {
        [Required(ErrorMessage = "Enter Quntity")]

        public decimal Qty { get; set; }
        [Required(ErrorMessage = "Enter Price")]

        public decimal Price { get; set; }
        [Required(ErrorMessage = "Enter OrderType Byu or Sell")]

        public order Ordertype { get; set; }

        public int status { get; set; }
    }
}
