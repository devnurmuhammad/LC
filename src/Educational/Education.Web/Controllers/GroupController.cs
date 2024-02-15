using Education.Application.DTOs;
using Education.Application.Interfaces;
using Education.Application.VIewModels;
using Microsoft.AspNetCore.Mvc;

namespace Education.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;
        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGroup([FromForm] GroupDTO groupDTO)
        {
            bool result = await _groupService.CreateGroup(groupDTO);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGroups()
        {
            IList<GroupViewModel> groups = await _groupService.GetAllGroups();

            return Ok(groups);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGroup(string number, [FromBody] GroupDTO groupDTO)
        {
            bool result = await _groupService.UpdateGroup(number, groupDTO);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGroup(string number)
        {
            bool result = await _groupService.DeleteGroup(number);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetGroupByNumber(string number)
        {
            GroupViewModel group = await _groupService.GetGroupByNumber(number);

            return Ok(group);
        }
        [HttpGet]
        public async Task<IActionResult> GetGroupCount()
        {
            long count = await _groupService.GetGroupCount();

            return Ok(count);
        }
    }
}