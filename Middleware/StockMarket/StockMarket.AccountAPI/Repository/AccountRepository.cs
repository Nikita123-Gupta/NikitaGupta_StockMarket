using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.DBAccess;
using StockMarket.AccountAPI.Models;

namespace StockMarket.AccountAPI.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private StockDBContext context;
        public AccountRepository()
        {
            context = new StockDBContext();
        }
        public void AddUser(User item)
        {
            context.Add(item);
            context.SaveChanges();
        }

        public User Validate(string uname, string pwd)
        {
            User user = context.Users.SingleOrDefault(u => u.UserName == uname && u.Password == pwd);
            return user;
        }
    }
}
