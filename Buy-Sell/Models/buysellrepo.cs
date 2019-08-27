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
            context.BuySellTable.Add(item);
            context.SaveChanges();
        }

       
    }
}
