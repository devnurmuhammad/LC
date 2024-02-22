using Microsoft.EntityFrameworkCore;
using Organizational.Application.Interfaces.Repositories;
using Organizational.Domain.Entities;
using Organizational.Infrastructure.Data;

namespace Organizational.Infrastructure.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly OrganizationDbContext _context;
        public BranchRepository(OrganizationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateBranch(Branch branch)
        {
            await _context.Branches.AddAsync(branch);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteBranch(int id)
        {
            Branch? branch = await _context.Branches.FirstOrDefaultAsync(x => x.Id == id);
            if (branch == null)
                throw new Exception("not found");

            _context.Branches.Remove(branch);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<IList<Branch>> GetAllBranches()
        {
            IList<Branch> branches = await _context.Branches.Include(x => x.Incomes)
                .Include(y => y.Outcomes)
                .Include(z => z.Employees)
                .ToListAsync();

            return branches;
        }

        public async Task<Branch> GetBranchById(int id)
        {
            Branch? branch = await _context.Branches.FirstOrDefaultAsync(x => x.Id == id);
            if (branch == null)
                throw new Exception("not found");

            return branch;
        }

        public async Task<Branch> GetBranchByName(string name)
        {
            Branch? branch = await _context.Branches
                .Include(y => y.Incomes)
                .Include(z => z.Outcomes)
                .Include(b => b.Employees)
                .FirstOrDefaultAsync(x => x.Name == name);

            return branch;
        }

        public async Task<int> GetBranchCount()
        {
            int count = await _context.Branches.CountAsync();

            return count;
        }

        public async Task<bool> UpdateBranch(Branch branch)
        {
            Branch? branch1 = await _context.Branches.FirstOrDefaultAsync(x => x.Id == branch.Id);
            if (branch1 is null)
                throw new Exception($"Branch {branch.Id} not found");

            _context.Branches.Update(branch);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
