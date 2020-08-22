using StockMarket.AccountAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.Repository;

namespace StockMarket.AccountAPI.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository repo;
        public AccountService(IAccountRepository _repo)
        {
            repo = _repo;
        }
        public void AddUser(User item)
        {
            repo.AddUser(item);
        }

        public User Validate(string uname, string pwd)
        {
            User user = repo.Validate(uname, pwd);
            return user;
        }
    }
}
