using Microsoft.AspNetCore.Mvc;
using Organizational.Application.DTOs;
using Organizational.Application.Interfaces.Repositories;
using Organizational.Application.Interfaces.Services;
using Organizational.Application.ViewModels;

namespace Organizational.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _service;
        public BranchController(IBranchRepository repository, IBranchService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBranch(BranchDTO branchDTO)
        {
            bool result = await _service.CreateBranch(branchDTO);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBranches()
        {
            IList<BranchViewModel> branches = await _service.GetAllBranches();

            return Ok(branches);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBranch(int id, BranchDTO branchDTO)
        {
            bool result = await _service.UpdateBranch(id, branchDTO);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBranch(int id)
        {
            bool result = await _service.DeleteBranch(id);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetBranchByName(string name)
        {
            BranchViewModel branch = await _service.GetBranchByName(name);

            return Ok(branch);
        }

        [HttpGet]
        public async Task<IActionResult> GetBranchCount()
        {
            int result = await _service.GetCountBranches();

            return Ok(result);
        }
    }
}
