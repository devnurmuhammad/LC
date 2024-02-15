using Education.Application.DTOs;
using Education.Application.VIewModels;

namespace Education.Application.Interfaces
{
    public interface IGroupService
    {
        public Task<bool> CreateGroup(GroupDTO groupDTO);
        public Task<IList<GroupViewModel>> GetAllGroups();
        public Task<bool> UpdateGroup(string number, GroupDTO groupDTO);
        public Task<bool> DeleteGroup(string number);
        public Task<GroupViewModel> GetGroupByNumber(string number);
        public Task<long> GetGroupCount();
    }
}
