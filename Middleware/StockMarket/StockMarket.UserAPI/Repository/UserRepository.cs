using StockMarket.UserAPI.DBAccess;
using StockMarket.UserAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.UserAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private UserDbContext context;
        public UserRepository() {
            context = new UserDbContext();
        }
        public List<Company> GetAllCompany()
        {
            return context.Companies.ToList();   
        }

        public List<IpoDetails> GetAllIpo()
        {
            return context.IpoDetails.ToList();
        }

        public Company GetCompanyById(string CompanyCode)
        {
            return context.Companies.SingleOrDefault(c => c.CompanyCode == CompanyCode);
        }

        public IpoDetails GetIpoById(int Id)
        {
            return context.IpoDetails.SingleOrDefault(i => i.Id == Id);
        }

        public StockPrice GetStockById(string CompanyCode, int RowId)
        {
            return context.StockPrices.SingleOrDefault(s => s.CompanyCode == CompanyCode && s.RowId == RowId);
        }

        public List<StockPrice> GetStockForCompany(string CompanyCode)
        {
            var stock = from s in context.StockPrices select s;
            stock = stock.Where(s => s.CompanyCode == CompanyCode);
            return stock.ToList();
                       
        }
    }
}
