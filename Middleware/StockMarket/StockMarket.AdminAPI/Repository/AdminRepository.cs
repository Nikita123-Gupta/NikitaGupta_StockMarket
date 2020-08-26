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

        public void AddIpo(IpoDetails item)
        {
            context.Add(item);
            context.SaveChanges();
        }

        public void DeleteCompany(string companyCode)
        {
            Company company = context.Companies.SingleOrDefault(c => c.CompanyCode == companyCode); 
            context.Remove(company);
            context.SaveChanges();
        }

        public void DeleteIpo(int Id)
        {
            IpoDetails ipo = context.IpoDetails.SingleOrDefault(i => i.Id == Id);
            context.Remove(ipo);
            context.SaveChanges();
        }

        public void EditCompany(string companyCode, string ceo)
        {
            Company company = context.Companies.SingleOrDefault(c => c.CompanyCode == companyCode);
            company.CEO = ceo;
            context.Update(company);
            context.SaveChanges();
        }
        public void UpdateIpo(int Id, string StockExchange, int TotalShares)
        {
            IpoDetails ipo = context.IpoDetails.SingleOrDefault(c => c.Id == Id);
            ipo.StockExchange = StockExchange;
            ipo.TotalShares = TotalShares;
            context.Update(ipo);
            context.SaveChanges();
        }
    }
}
