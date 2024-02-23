using Organizational.Domain.Entities;

namespace Organizational.Application.Interfaces.Repositories
{
    public interface IContractRepository
    {
        public Task<bool> CreateContract(Contract contract);
        public Task<IList<Contract>> GetAllContracts();
        public Task<bool> UpdateContract(Contract contract);
        public Task<bool> DeleteContract(int id);
        public Task<long> GetContractCount();
        public Task<Contract> GetContractById(int id);
        public Task<IList<Contract>> GetContractsByDate(DateTime date);
    }
}
