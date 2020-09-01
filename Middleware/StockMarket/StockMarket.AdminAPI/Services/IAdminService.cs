using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;
using StockMarket.AdminAPI.Repository;

namespace StockMarket.AdminAPI.Services
{
    public interface IAdminService
    {
       
        public void AddCompany(Company company);
        public void EditCompany(Company company);
        public void DeleteCompany(string companyCode);
        public List<Company> GetAllCompany();
        public void UpdateIpo(IpoDetails item);
        public void AddIpo(IpoDetails item);
        public void DeleteIpo(int Id);
        public List<IpoDetails> GetAllIpo();
    }
}
