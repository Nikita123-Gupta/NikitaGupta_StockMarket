using StockMarket.UserAPI.Models;
using StockMarket.UserAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StockMarket.UserAPI.Services
{
    public class UserService : IUserService
    {
        private IUserRepository repo;
        public UserService(IUserRepository _repo)
        {
            repo = _repo;
        }
        public List<Company> GetAllCompany()
        {
            return repo.GetAllCompany();
        }

        public List<IpoDetails> GetAllIpo()
        {
            return repo.GetAllIpo();
        }

        public Company GetCompanyById(string CompanyCode)
        {
            return repo.GetCompanyById(CompanyCode);
        }

        public IpoDetails GetIpoById(int Id)
        {
            return repo.GetIpoById(Id);
        }

        public StockPrice GetStockById(string CompanyCode, int RowId)
        {
            return repo.GetStockById(CompanyCode, RowId);
        }

        public List<StockPrice> GetStockForCompany(string CompanyCode)
        {
            return repo.GetStockForCompany(CompanyCode);
        }
    }
}
