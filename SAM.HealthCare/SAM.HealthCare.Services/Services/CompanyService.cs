using System;
using System.Collections.Generic;
using System.Linq;
using SAM.HealthCare.Domain.Entities;
using SAM.HealthCare.Domain.IRepositories;
using SAM.HealthCare.Services.DTOs;

namespace SAM.HealthCare.Services.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public void Create(CompanyDto companyDto)
        {
            var company = new Company
            {
                Address = companyDto.Address,
                Name = companyDto.Name,
                PhoneNumber = companyDto.PhoneNumber
            };

            _companyRepository.Create(company);
            _companyRepository.UnitOfWork.Commit();
        }

        public IList<CompanyDto> GetAll()
        {
            var companies = _companyRepository.GetAll();

            return companies.Select(x => new CompanyDto(x.ID, x.Name, x.PhoneNumber, x.Address)).ToList();
        }

    }
}
