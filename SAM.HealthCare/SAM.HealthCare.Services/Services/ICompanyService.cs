using System.Collections.Generic;
using SAM.HealthCare.Services.DTOs;

namespace SAM.HealthCare.Services.Services
{
    public interface ICompanyService : IApplicationService
    {
        void Create(CompanyDto company);
        IList<CompanyDto> GetAll();
    }
}