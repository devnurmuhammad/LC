using Organizational.Application.DTOs;
using Organizational.Application.Interfaces.Repositories;
using Organizational.Application.Interfaces.Services;
using Organizational.Application.ViewModels;
using Organizational.Domain.Entities;

namespace Organizational.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public Task<bool> CreateCompany(CompanyDTO company)
        {
            throw new NotImplementedException();
        }

        public CompanyViewModel GetCompany()
        {
            Company company = _companyRepository.GetCompany();
            CompanyViewModel result = new CompanyViewModel()
            {
                Name = company.Name,
                Address = company.Address,
                Email = company.Email,
                Phone = company.Phone,
                Website = company.Website,
                Id = company.Id,
                Branches = company.Branches,
                CEO = company.CEO,
            };

            return result;
        }

        public async Task<bool> UpdateCompany(CompanyDTO dto)
        {
            Company company = _companyRepository.GetCompany();
            company.Name = dto.Name;
            company.Address = dto.Address;
            company.Email = dto.Email;
            company.Phone = dto.Phone;
            company.Website = dto.Website;
            company.CEO = dto.CEO;
            
            bool result = await _companyRepository.UpdateCompany(company);

            return result;
        }
    }
}
