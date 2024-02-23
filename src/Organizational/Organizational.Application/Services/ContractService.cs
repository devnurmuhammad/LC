using Organizational.Application.DTOs;
using Organizational.Application.Interfaces.Repositories;
using Organizational.Application.Interfaces.Services;
using Organizational.Application.ViewModels;
using Organizational.Domain.Entities;

namespace Organizational.Application.Services
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _repository;
        public ContractService(IContractRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> CreateContract(ContractDTO dto)
        {
            Contract contract = new Contract()
            {
                Amount = dto.Amount,
                Description = dto.Description,
                PaymentDate = dto.PaymentDate,
                Comment = dto.Comment,
                EmployeeId = dto.EmployeeId,
            };

            bool result = await _repository.CreateContract(contract);

            return result;
        }

        public async Task<bool> DeleteContract(int id)
        {
            Contract contract = await _repository.GetContractById(id);
            if (contract == null)
                throw new Exception("not found");

            bool result = await _repository.DeleteContract(id);

            return result;
        }

        public async Task<IList<ContractViewModel>> GetAllContracts()
        {
            IList<Contract> contracts = await _repository.GetAllContracts();
            IList<ContractViewModel> result = contracts.Select(x => new ContractViewModel()
            {
                Amount = x.Amount,
                Description = x.Description,
                PaymentDate = x.PaymentDate,
                Comment = x.Comment,
                EmployeeId = x.EmployeeId,
            }).ToList();

            return result;
        }

        public async Task<IList<ContractViewModel>> GetContractByDate(DateTime date)
        {
            IList<Contract> contracts = await _repository.GetContractsByDate(date);
            IList<ContractViewModel> result = contracts.Select(x => new ContractViewModel()
            {
                Amount = x.Amount,
                Description = x.Description,
                PaymentDate = x.PaymentDate,
                Comment = x.Comment,
                EmployeeId = x.EmployeeId,
            }).ToList();

            return result;
        }

        public async Task<ContractViewModel> GetContractById(int id)
        {
            Contract contract = await _repository.GetContractById(id);
            ContractViewModel result = new ContractViewModel()
            {
                Amount = contract.Amount,
                Description = contract.Description,
                PaymentDate = contract.PaymentDate,
                Comment = contract.Comment,
                EmployeeId = contract.EmployeeId,
            };

            return result;
        }

        public async Task<long> GetContractCount()
        {
            long result = await _repository.GetContractCount();

            return result;
        }

        public async Task<bool> UpdateContract(int id, ContractDTO dto)
        {
            Contract? contract = await _repository.GetContractById(id);
            if (contract == null)
                throw new Exception("not found");

            contract.Amount = dto.Amount;
            contract.Description = dto.Description;
            contract.PaymentDate = dto.PaymentDate;
            contract.Comment = dto.Comment;
            contract.EmployeeId = dto.EmployeeId;
            contract.UpdateAt = dto.UpdateAt;
            contract.UpdateEmployeeId = dto.UpdateEmployeeId;

            bool result = await _repository.UpdateContract(contract);

            return result;
        }
    }
}
