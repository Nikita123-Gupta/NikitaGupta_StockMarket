using StockMarket.AccountAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Services
{
    public interface IAccountService
    {
        public void AddUser(User item);

        public User Validate(string uname, string pwd);
    }
}
