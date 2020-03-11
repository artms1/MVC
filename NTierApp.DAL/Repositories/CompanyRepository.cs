using NTierApp.DAL.Entities;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NTierApp.DAL.Repositories
{
    class CompanyRepository : IRepository<Company>
    {
        private readonly DatabaseContext db;

        public CompanyRepository(DatabaseContext context)
        {
            this.db = context;
        }
        public void Create(Company item)
        {
            db.Companies.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            return db.Companies.ToList();
        }

        public void Update(Company item)
        {
            throw new NotImplementedException();
        }

        Company IRepository<Company>.Get(int id)
        {
            throw new NotImplementedException();
        }

    }
}
