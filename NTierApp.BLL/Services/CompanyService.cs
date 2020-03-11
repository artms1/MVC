using NTierApp.BLL.Models;
using NTierApp.DAL.Entities;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Interfaces
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork database;
        public CompanyService(IUnitOfWork uow)
        {
            this.database = uow;
        }

        public IEnumerable<CompanyModel> GetAllCompanies()
        {
            var companies = database.Companies.GetAll().ToList();
            var mapper = Automapper.GetMapper();
            var companiesModel = companies.Select(x => mapper.Map(x, typeof(Company), typeof(CompanyModel)) as CompanyModel).ToList();
            return companiesModel;
        }

        public void AddCompany(CompanyModel model)
        {

            Company company = new Company { Name = model.Name, Address = model.Address };
            database.Companies.Create(company);
            database.Save();
        }
    }
}
