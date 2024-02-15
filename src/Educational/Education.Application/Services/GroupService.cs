using Education.Application.DTOs;
using Education.Application.Interfaces;
using Education.Application.Repositories;
using Education.Application.VIewModels;
using Education.Domain.Entities;
using Education.Domain.Enums.GroupEnums;

namespace Education.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _repository;
        public GroupService(IGroupRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> CreateGroup(GroupDTO groupDTO)
        {
            Group group = new Group()
            {
                Number = groupDTO.Number,
                StartedDate = groupDTO.StartedDate,
                FinishedDate = groupDTO.FinishedDate,
                Status = groupDTO.Status,
                RoomId = groupDTO.RoomId,
            };

            bool result = await _repository.CreateGroup(group);

            return result;
        }

        public async Task<bool> DeleteGroup(string number)
        {
            Group group = await _repository.GetGroupByNumber(number);
            if (group == null)
                throw new Exception("Not found");

            bool result = await _repository.DeleteGroup(number);

            return result;
        }

        public async Task<IList<GroupViewModel>> GetAllGroups()
        {
            IList<Group> groups = await _repository.GetAllGroups();
            IList<GroupViewModel> result = groups.Select(x => new GroupViewModel
            {
                Id = x.Id,
                Number = x.Number,
                StartedDate = x.StartedDate,
                FinishedDate = x.FinishedDate,
                Status = Enum.GetName(typeof(GroupStatus), (int)x.Status),
                RoomId = x.RoomId,
            }).ToList();

            return result;
        }

        public async Task<GroupViewModel> GetGroupByNumber(string number)
        {
            Group group = await _repository.GetGroupByNumber(number);
            if (group == null)
                throw new Exception($"Unable to find group {number}");

            GroupViewModel result = new GroupViewModel()
            {
                Id = group.Id,
                Number = group.Number,
                StartedDate = group.StartedDate,
                FinishedDate = group.FinishedDate,
                Status = Enum.GetName(typeof(GroupStatus), (int)group.Status),
                RoomId = group.RoomId,
            };

            return result;
        }

        public async Task<long> GetGroupCount()
        {
            return await _repository.GetGroupCount();
        }

        public async Task<bool> UpdateGroup(string number, GroupDTO groupDTO)
        {
            Group group = await _repository.GetGroupByNumber(number);
            if (group == null)
                throw new Exception($"Unable to find group {number}");

            group.Number = number;
            group.StartedDate = DateTime.Now;
            group.FinishedDate = DateTime.Now;
            group.Status = groupDTO.Status;
            group.RoomId = groupDTO.RoomId;

            bool result = await _repository.UpdateGroup(group);

            return result;
        }
    }
}
