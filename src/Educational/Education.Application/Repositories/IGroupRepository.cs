using Education.Domain.Entities;

namespace Education.Application.Repositories
{
    public interface IGroupRepository
    {
        public Task<bool> CreateGroup(Group group);
        public Task<IList<Group>> GetAllGroups();
        public Task<bool> UpdateGroup(Group group);
        public Task<bool> DeleteGroup(string number);
        public Task<Group> GetGroupByNumber(string number);
        public Task<long> GetGroupCount();
    }
}
