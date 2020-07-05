using SAM.HealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace SAM.HealthCare.Domain.IRepositories
{
    public interface ICompanyRepositoriy
    {
        int Create(Company company);
    }
}
