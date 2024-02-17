using Organizational.Application.DTOs;
using Organizational.Application.ViewModels;

namespace Organizational.Application.Interfaces.Services
{
    public interface ICompanyService
    {
        public Task<bool> CreateCompany(CompanyDTO company);
        public CompanyViewModel GetCompany();
        public Task<bool> UpdateCompany(CompanyDTO company);
    }
}
