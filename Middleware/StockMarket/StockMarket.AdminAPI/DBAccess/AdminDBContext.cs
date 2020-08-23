using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options;

namespace StockMarket.AdminAPI.DBAccess
{
    public class AdminDBContext:DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=RTH\TEW_SQLEXPRESS;Initial Catalog=StockMarketDB;Integrated Security=True");
        }



    }
}
