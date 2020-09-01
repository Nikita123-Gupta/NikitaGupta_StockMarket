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

        public void EditCompany(Company company)
        {
            context.Companies.Update(company);
            context.SaveChanges();
        }

        public List<Company> GetAllCompany()
        {
            return context.Companies.ToList();
        }

        public List<IpoDetails> GetAllIpo()
        {
            return context.IpoDetails.ToList();
        }

        public void UpdateIpo(IpoDetails ipo)
        {
           
            context.IpoDetails.Update(ipo);
            context.SaveChanges();
        }
    }
}
