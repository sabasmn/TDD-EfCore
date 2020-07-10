using System.Linq;
using SAM.HealthCare.Services.DTOs;
using SAM.HealthCare.Services.Services;
using Xunit;

namespace SAM.HealthCare.Tests
{
    public class CompanyTest : BaseTest
    {
        [Fact]
        public void CompanyTest_Create_Succeed()
        {
            // arrange 
            var companyDto = new CompanyDto
            {
                Name = "Microsoft",
                PhoneNumber = "+1-154544",
                Address = "Redmond, Washington, United States"
            };

            // act
            var companyService = GetAppService<ICompanyService>();
            companyService.Create(companyDto);

            //check
            var allCompanies = companyService.GetAll();
            var firstCompany = allCompanies.FirstOrDefault();

            Assert.Equal(1, allCompanies.Count);
            Assert.NotNull(firstCompany);
            Assert.Equal(companyDto.Name, firstCompany.Name);
            Assert.Equal(companyDto.PhoneNumber, firstCompany.PhoneNumber);
            Assert.Equal(companyDto.Address, firstCompany.Address);
            Assert.True(firstCompany.ID > 0);
        }
    }
}
