using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buy_Sell.Models;
using Buy_Sell.viewmodel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Buy_Sell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateOrderController : Controller
    {

        private readonly Ibuysellrepo<buysellitem> ibuysellrepo;

        public CreateOrderController(Ibuysellrepo<buysellitem> ibuysellrepo)
        {
            this.ibuysellrepo = ibuysellrepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<buysellitem> buysellll = ibuysellrepo.GetAll();
            return Ok(buysellll);
        }

        [HttpPost]
        public IActionResult Create(buysellcreatviewmodel model)
        {
            
            if (ModelState.IsValid)
            {
                buysellitem item = new buysellitem
                {
                    
                    Qty = model.Qty,
                    Price = model.Price,
                    Ordertype = model.Ordertype,
                     
                };
                
                ibuysellrepo.Add(item);
             }
            
            return Ok();

        }

    }
}

    
