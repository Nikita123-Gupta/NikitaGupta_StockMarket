using Microsoft.EntityFrameworkCore;
using StockMarket.AccountAPI.Models;

namespace StockMarket.AccountAPI.DBAccess
{
    public class StockDBContext:DbContext
    {
       public DbSet<User> Users { get; set; }
       public DbSet<StockPrice> StockPrices { get; set; }

        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=RTH\TEW_SQLEXPRESS;Initial Catalog=StockMarketDB;Integrated Security=True");
        }
    }
}
