using SAM.HealthCare.Services.ViewModels;
using System.Collections.Generic;

namespace SAM.HealthCare.Services
{
    public interface ICompanyService
    {
        void Create(CompanyDTO company);
        void Update(CompanyDTO company);
        IList<CompanyDTO> GetAll();
    }
}