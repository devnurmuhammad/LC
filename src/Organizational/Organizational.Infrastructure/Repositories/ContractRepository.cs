using Microsoft.EntityFrameworkCore;
using Organizational.Application.Interfaces.Repositories;
using Organizational.Domain.Entities;
using Organizational.Infrastructure.Data;

namespace Organizational.Infrastructure.Repositories
{
    public class ContractRepository : IContractRepository
    {
        private readonly OrganizationDbContext _context;
        public ContractRepository(OrganizationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateContract(Contract contract)
        {
            await _context.Contracts.AddAsync(contract);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteContract(int id)
        {
            Contract? contract = await _context.Contracts.FirstOrDefaultAsync(x => x.Id == id);
            if (contract is null)
                return false;

            _context.Contracts.Remove(contract);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<IList<Contract>> GetAllContracts()
        {
            IList<Contract> contracts = await _context.Contracts
                .Include(x => x.EmployeeId)
                .ToListAsync();

            return contracts;
        }

        public async Task<Contract> GetContractById(int id)
        {
            Contract? contract = await _context.Contracts.FirstOrDefaultAsync(x => x.Id == id);
            if (contract != null)
                return contract;

            throw new Exception("not found");
        }

        public async Task<long> GetContractCount()
        {
            long count = await _context.Contracts.CountAsync();

            return count;
        }

        public async Task<IList<Contract>> GetContractsByDate(DateTime date)
        {
            DateTime startedDate = date.Date;
            DateTime endDate = startedDate.AddDays(1);
                
            IList<Contract> contracts = await _context.Contracts
                .Where(y => y.PaymentDate >= date && y.PaymentDate < endDate)
                .ToListAsync();

            return contracts;
        }

        public async Task<bool> UpdateContract(Contract contract)
        {
            _context.Contracts.Update(contract);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
