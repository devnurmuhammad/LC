using Microsoft.AspNetCore.Mvc;
using Organizational.Application.DTOs;
using Organizational.Application.Interfaces.Services;
using Organizational.Application.ViewModels;

namespace Organizational.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _service;
        public ContractController(IContractService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateContract(ContractDTO contract)
        {
            bool result = await _service.CreateContract(contract);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllContracts()
        {
            IList<ContractViewModel> contracts = await _service.GetAllContracts();

            return Ok(contracts);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContract(int id, ContractDTO contract) 
        {
            bool result = await _service.UpdateContract(id, contract); 

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteContract(int id)
        {
            bool result = await _service.DeleteContract(id);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetContractsByDate(DateTime date)
        {
            IList<ContractViewModel> contracts = await _service.GetContractByDate(date);

            return Ok(contracts);
        }

        [HttpGet]
        public async Task<IActionResult> GetContractsCount()
        {
            long count = await _service.GetContractCount();

            return Ok(count);
        }
    }
}
