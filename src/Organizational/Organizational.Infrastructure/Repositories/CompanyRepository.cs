using Organizational.Application.Interfaces.Repositories;
using Organizational.Domain.Entities;
using Organizational.Infrastructure.Data;

namespace Organizational.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly OrganizationDbContext _context;
        public CompanyRepository(OrganizationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCompany(Company company)
        {
            await _context.Company.AddAsync(company);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public Company GetCompany()
        {
            Company? company = _context.Company.FirstOrDefault();

            return company;
        }

        public async Task<bool> UpdateCompany(Company company)
        {
            _context.Company.Update(company);

            int result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
