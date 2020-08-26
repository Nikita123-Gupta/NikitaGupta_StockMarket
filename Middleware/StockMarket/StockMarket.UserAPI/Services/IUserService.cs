using StockMarket.UserAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.UserAPI.Repository;

namespace StockMarket.UserAPI.Services
{
    public interface IUserService
    {
        public List<Company> GetAllCompany();
        public Company GetCompanyById(string CompanyCode);
        public List<IpoDetails> GetAllIpo();
        public IpoDetails GetIpoById(int Id);

        public List<StockPrice> GetStockForCompany(string CompanyCode);
        public StockPrice GetStockById(string CompanyCode, int RowId);
    }
}
