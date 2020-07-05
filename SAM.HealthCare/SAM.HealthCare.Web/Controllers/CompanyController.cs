using Microsoft.AspNetCore.Mvc;
using SAM.HealthCare.Services;
using SAM.HealthCare.Services.ViewModels;

namespace SAM.HealthCare.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CompanyDTO companyDTO)
        {
            _companyService.Create(companyDTO);

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}