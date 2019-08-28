using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buy_Sell.Models
{
    public interface Ibuysellrepo<buysellitem>
    {
        IEnumerable<buysellitem> GetAll();
        buysellitem Get(int id);
        void Add(buysellitem item);
     
       

    }
}
