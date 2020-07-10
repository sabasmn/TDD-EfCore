using System.Collections.Generic;
using SAM.HealthCare.Domain.Entities;
using SAM.HealthCare.Domain.Base;

namespace SAM.HealthCare.Domain.IRepositories
{
    public interface ICompanyRepository : IRepository
    {
        int Create(Company company);
        List<Company> GetAll();
    }
}
