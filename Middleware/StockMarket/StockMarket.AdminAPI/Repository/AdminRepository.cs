using StockMarket.AdminAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.DBAccess;
using Microsoft.EntityFrameworkCore;

namespace StockMarket.AdminAPI.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private AdminDBContext context;

        public AdminRepository()
        {
            context = new AdminDBContext();
        }
        public void AddCompany(Company company)
        {
            context.Add(company);
            context.SaveChanges();
        }

        public void DeleteCompany(string companyCode)
        {
            Company company = context.Companies.SingleOrDefault(c => c.CompanyCode == companyCode); 
            context.Remove(company);
            context.SaveChanges();
        }

        public void EditCompany(string companyCode, string ceo)
        {
            Company company = context.Companies.SingleOrDefault(c => c.CompanyCode == companyCode);
            company.CEO = ceo;
            context.Update(company);
            context.SaveChanges();
        }
    }
}
