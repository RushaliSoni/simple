using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buy_Sell.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Buy_Sell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateOrderController : ControllerBase
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
        public IActionResult Post([FromBody] buysellitem buysellitem)
        {
            if (buysellitem == null)
            {
                return BadRequest("Employee is null.");
            }

            ibuysellrepo.Add(buysellitem);
            return CreatedAtRoute(
                  "Get",
                  new { Id = buysellitem.Id },
                  buysellitem);
        }

    }




    }
