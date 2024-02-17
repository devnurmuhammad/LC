using Organizational.Domain.Entities;

namespace Organizational.Application.Interfaces.Repositories
{
    public interface ICompanyRepository
    {
        public Task<bool> CreateCompany(Company company);
        public Company GetCompany();
        public Task<bool> UpdateCompany(Company company);
    }
}
