using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buy_Sell.Models
{
    public class buysellcontext : DbContext
    {
        public buysellcontext(DbContextOptions<buysellcontext> options)
            : base(options)
        {
        }

        public DbSet<buysellitem> BuySellTable { get; set; }
    }
}
