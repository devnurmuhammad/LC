using Organizational.Application.DTOs;
using Organizational.Application.Interfaces.Repositories;
using Organizational.Application.Interfaces.Services;
using Organizational.Application.ViewModels;
using Organizational.Domain.Entities;

namespace Organizational.Application.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _repository;
        public BranchService(IBranchRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> CreateBranch(BranchDTO branchDTO)
        {
            Branch branch = new Branch()
            {
                Name = branchDTO.Name,
                Address = branchDTO.Address,
                Phone = branchDTO.Phone,
                CompanyId = 1,
            };

            bool result = await _repository.CreateBranch(branch);

            return result;
        }

        public async Task<bool> DeleteBranch(int id)
        {
            bool result = await _repository.DeleteBranch(id);

            return result;
        }

        public async Task<IList<BranchViewModel>> GetAllBranches()
        {
            IList<Branch> branches = await _repository.GetAllBranches();
            IList<BranchViewModel> result = branches.Select(x => new BranchViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                Phone = x.Phone,
                CompanyId = x.CompanyId,
                Employees = x.Employees,
                Incomes = x.Incomes,
                Outcomes = x.Outcomes,
            }).ToList();

            return result;
        }

        public async Task<BranchViewModel> GetBranchByName(string name)
        {
            Branch branch = await _repository.GetBranchByName(name);
            BranchViewModel result = new BranchViewModel()
            {
                Id = branch.Id,
                Name = branch.Name,
                Address = branch.Address,
                Phone = branch.Phone,
                CompanyId = branch.CompanyId,
                Employees = branch.Employees,
                Incomes = branch.Incomes,
                Outcomes = branch.Outcomes,
            };

            return result;
        }

        public async Task<int> GetCountBranches()
        {
            int count = await _repository.GetBranchCount();

            return count;
        }

        public async Task<bool> UpdateBranch(int id, BranchDTO branchDTO)
        {
            Branch branch = await _repository.GetBranchById(id);
            if (branch == null)
            {
                throw new Exception("not found");
            }
            branch.Name = branchDTO.Name;
            branch.Address = branchDTO.Address;
            branch.Phone = branchDTO.Phone;
            
            bool reslut = await _repository.UpdateBranch(branch);

            return reslut;
        }
    }
}
