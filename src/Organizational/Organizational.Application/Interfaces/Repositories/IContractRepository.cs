using Organizational.Domain.Entities;

namespace Organizational.Application.Interfaces.Repositories
{
    public interface IContractRepository
    {
        public Task<bool> CreateContract(Contract contract);
        public Task<IList<Contract>> GetAllContracts();
        public Task<bool> UpdateContract(int id);
        public Task<bool> DeleteContract(int id);
        public Task<long> GetContractCount(int id);
        public Task<Contract> GetContractById(int id);
        public Task<IList<Contract>> GetContractsByDate(DateTime date);
    }
}
