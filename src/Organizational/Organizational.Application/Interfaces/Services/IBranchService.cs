using Organizational.Application.DTOs;
using Organizational.Application.ViewModels;

namespace Organizational.Application.Interfaces.Services
{
    public interface IBranchService
    {
        public Task<bool> CreateBranch(BranchDTO branchDTO);
        public Task<IList<BranchViewModel>> GetAllBranches();
        public Task<bool> UpdateBranch(int id,  BranchDTO branchDTO);
        public Task<bool> DeleteBranch(int id);
        public Task<BranchViewModel> GetBranchByName(string name);
        //public Task<BranchViewModel> GetBranchById(int id);
        public Task<int> GetCountBranches();
    }
}
