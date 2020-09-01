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

        public void EditCompany(Company company)
        {
            repo.EditCompany(company);
        }

        public void DeleteCompany(string companyCode)
        {
            repo.DeleteCompany(companyCode);
        }

        public void UpdateIpo(IpoDetails ipo)
        {
            repo.UpdateIpo(ipo);
        }

        public void AddIpo(IpoDetails item)
        {
            repo.AddIpo(item);
        }

        public void DeleteIpo(int Id)
        {
            repo.DeleteIpo(Id);
        }

        public List<Company> GetAllCompany()
        {
            return repo.GetAllCompany();
        }

        public List<IpoDetails> GetAllIpo()
        {
            return repo.GetAllIpo();
        }
    }
}
