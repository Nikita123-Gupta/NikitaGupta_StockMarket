using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockMarket.ExcelAPI.Models;

namespace StockMarket.ExcelAPI.DBAcess
{
    public class ExcelDBContext:DbContext
    {
        public DbSet<StockPrice> StockPrices { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=RTH\TEW_SQLEXPRESS;Initial Catalog=StockMarketDB;Integrated Security=True");
        }

    }
}
