using Organizational.Application.DTOs;
using Organizational.Application.ViewModels;

namespace Organizational.Application.Interfaces.Services
{
    public interface IContractService
    {
        public Task<bool> CreateContract(ContractDTO contract);
        public Task<IList<ContractViewModel>> GetAllContracts();
        public Task<bool> UpdateContract(int id, ContractDTO contract);
        public Task<bool> DeleteContract(int id);
        public Task<ContractViewModel> GetContractById(int id);
        public Task<IList<ContractViewModel>> GetContractByDate(DateTime date);
        public Task<long> GetContractCount();    
    }
}
