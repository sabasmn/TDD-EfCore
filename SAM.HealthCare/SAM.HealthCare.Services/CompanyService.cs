using System;
using System.Collections.Generic;
using SAM.HealthCare.Domain.IRepositories;
using SAM.HealthCare.Services.ViewModels;

namespace SAM.HealthCare.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepositoriy _companyRepositoriy;
        public CompanyService(ICompanyRepositoriy companyRepositoriy)
        {
            _companyRepositoriy = companyRepositoriy;
        }
        public void Create(CompanyDTO company)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(CompanyDTO company)
        {
            throw new NotImplementedException();
        }
    }
}
