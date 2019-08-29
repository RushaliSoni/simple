using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Buy_Sell.Models;
using Buy_Sell.viewmodel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Buy_Sell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateOrderController : Controller
    {

        private readonly Ibuysellrepo<buysellitem> ibuysellrepo;
        private readonly ILogger<CreateOrderController> logger;

        public CreateOrderController(Ibuysellrepo<buysellitem> ibuysellrepo, ILogger<CreateOrderController> logger)
        {
            this.ibuysellrepo = ibuysellrepo;
            this.logger = logger;
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
                var url = "http://65114-1607ss26.azurewebsites.net/exchange/kraken/ticker?symbol=BTC/USD";
                WebRequest request = HttpWebRequest.Create(url);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseText = reader.ReadToEnd();

                var url1 = "http://65114-1607ss26.azurewebsites.net/exchange/binance/ticker?symbol=BTC/USDT";
                WebRequest request1 = HttpWebRequest.Create(url1);
                WebResponse response1 = request1.GetResponse();
                StreamReader reader1 = new StreamReader(response1.GetResponseStream());
                string responseText1 = reader1.ReadToEnd();

                var url2 = "http://65114-1607ss26.azurewebsites.net/exchange/exmo/ticker?symbol=BTC/USDT";
                WebRequest request2 = HttpWebRequest.Create(url2);
                WebResponse response2 = request2.GetResponse();
                StreamReader reader2 = new StreamReader(response2.GetResponseStream());
                string responseText2 = reader2.ReadToEnd();



                Log.Logger = new LoggerConfiguration().WriteTo.File("TextFile.txt").CreateLogger();
                Log.Information(responseText);
                Log.Information(responseText1);
                Log.Information(responseText2);

            }

            return Ok();

        }



    }
}



