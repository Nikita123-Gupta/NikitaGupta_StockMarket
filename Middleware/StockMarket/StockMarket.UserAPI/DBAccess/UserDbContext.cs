using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockMarket.UserAPI.Models;

namespace StockMarket.UserAPI.DBAccess
{
    public class UserDbContext:DbContext
    {
        public DbSet<IpoDetails> IpoDetails { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=RTH\TEW_SQLEXPRESS;Initial Catalog=StockMarketDB;Integrated Security=True");
        }

    }
}
