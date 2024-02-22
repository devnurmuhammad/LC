using Organizational.Domain.Entities;

namespace Organizational.Application.Interfaces.Repositories
{
    public interface IBranchRepository
    {
        public Task<bool> CreateBranch(Branch branch);
        public Task<IList<Branch>> GetAllBranches();
        public Task<bool> UpdateBranch(Branch branch);
        public Task<bool> DeleteBranch(int id);
        public Task<Branch> GetBranchByName(string name);
        public Task<Branch> GetBranchById(int id);
        public Task<int> GetBranchCount();
    }
}
