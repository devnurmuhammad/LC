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
            CompanyViewModel result =  new CompanyViewModel()
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

        public Task<bool> UpdateCompany(CompanyDTO company)
        {
            throw new NotImplementedException();
        }
    }
}
