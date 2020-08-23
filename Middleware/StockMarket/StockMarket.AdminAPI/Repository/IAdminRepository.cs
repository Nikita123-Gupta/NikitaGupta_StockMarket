using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;

namespace StockMarket.AdminAPI.Repository
{
    public interface IAdminRepository
    {
        public void AddCompany(Company company);
        public void EditCompany(string companyCode, string ceo);
        public void DeleteCompany(string companyCode);

    }
}
