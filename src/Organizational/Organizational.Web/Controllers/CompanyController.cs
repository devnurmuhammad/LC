using Microsoft.AspNetCore.Mvc;
using Organizational.Application.DTOs;
using Organizational.Application.Interfaces.Services;
using Organizational.Application.ViewModels;

namespace Organizational.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult GetCompany()
        {
            CompanyViewModel company = _companyService.GetCompany();

            return Ok(company);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCompany([FromForm] CompanyDTO company)
        {
            await _companyService.UpdateCompany(company);
            return Ok(company);
        }
    }
}
