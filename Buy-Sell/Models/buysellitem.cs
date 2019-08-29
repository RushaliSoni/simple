using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Buy_Sell.Models
{
    public class buysellitem
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Quntity")]
        public decimal Qty { get; set; }
        [Required(ErrorMessage ="Enter Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage ="Enter OrderType buy or sell")]
        public order Ordertype { get; set; }
        [Required]
        public int status { get; set; }


    }
    public enum order
    {
         buy = 1,
         sell = 2
    }
}
