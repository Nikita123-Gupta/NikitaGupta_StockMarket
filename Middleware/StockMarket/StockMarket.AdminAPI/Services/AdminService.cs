using StockMarket.AdminAPI.Models;
using StockMarket.AdminAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AdminAPI.Services
{
    public class AdminService:IAdminService
    {
        private IAdminRepository repo;

        public AdminService(IAdminRepository _repo) {
            repo = _repo;
        }
        public void AddCompany(Company company)
        {
            repo.AddCompany(company);
        }

        public void EditCompany(string companyCode, string ceo)
        {
            repo.EditCompany(companyCode, ceo);
        }

        public void DeleteCompany(string companyCode)
        {
            repo.DeleteCompany(companyCode);
        }

       

    }
}
