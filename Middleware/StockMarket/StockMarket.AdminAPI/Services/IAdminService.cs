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
        public void EditCompany(string companyCode,string ceo);
        public void DeleteCompany(string companyCode);
    }
}
