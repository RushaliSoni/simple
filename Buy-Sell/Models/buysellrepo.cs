using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buy_Sell.Models
{
    public class buysellrepo : Ibuysellrepo<buysellitem>
    {
        private readonly buysellcontext context;

        public buysellrepo(buysellcontext context )
        {
            this.context = context;
        }

        public IEnumerable<buysellitem> GetAll()
        {
            return context.BuySellTable.ToList();

        }
        public buysellitem Get(int id)
        {
            return context.BuySellTable
                  .FirstOrDefault(e => e.Id == id);
        }
        public void Add(buysellitem item)
        {
            var query = (from s in context.BuySellTable
                         where s.Price.Equals(item.Price) && s.Qty.Equals(item.Qty) && !s.Ordertype.Equals(item.Ordertype) && s.status.Equals(item.status)
                         select s).FirstOrDefault();


            if (query != null)
            {
               
                context.BuySellTable.Add(item);
                query.status = 1;
                item.status = 1;
                context.Update(query);
                
            }
            else
            {
                context.BuySellTable.Add(item);
            }
            context.SaveChanges();




        }



    }
}
