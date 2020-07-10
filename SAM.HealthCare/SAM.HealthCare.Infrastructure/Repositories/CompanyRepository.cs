using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SAM.HealthCare.Domain.Entities;
using SAM.HealthCare.Domain.IRepositories;
using SAM.HealthCare.Infrastructure.DatabaseContext;

namespace SAM.HealthCare.Infrastructure.Repositories
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public int Create(Company company)
        {
            DbSet.Add(company);

            UnitOfWork.Commit();

            return company.ID;
        }

        public List<Company> GetAll()
        {
            return DbSet.ToList();
        }

        public CompanyRepository(HealthCareDbContext dbContext) : base(dbContext)
        {
        }
    }
}
