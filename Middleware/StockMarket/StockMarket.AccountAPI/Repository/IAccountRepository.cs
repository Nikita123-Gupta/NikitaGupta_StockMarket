using StockMarket.AccountAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Repository
{
    public interface IAccountRepository
    {
         public void AddUser(User item);
     
         public User Validate(string uname, string pwd);
    }
}
