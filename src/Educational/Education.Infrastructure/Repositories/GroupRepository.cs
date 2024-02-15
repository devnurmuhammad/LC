using Education.Application.Repositories;
using Education.Domain.Entities;
using Education.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Education.Infrastructure.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly EducationDbContext _context;
        public GroupRepository(EducationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateGroup(Group group)
        {
            await _context.Groups.AddAsync(group);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteGroup(string number)
        {
            Group group = await _context.Groups.FirstOrDefaultAsync(g => g.Number == number);
            _context.Groups.Remove(group);
            int count = await _context.SaveChangesAsync();

            return count > 0;
        }

        public async Task<IList<Group>> GetAllGroups()
        {
            IList<Group> groups = await _context.Groups.ToListAsync();

            return groups;
        }

        public async Task<Group> GetGroupByNumber(string number)
        {
            Group group = await _context.Groups.FirstOrDefaultAsync(g => g.Number == number);

            return group;
        }

        public async Task<long> GetGroupCount()
        {
            long count = await _context.Groups.CountAsync();

            return count;
        }

        public async Task<bool> UpdateGroup(Group group)
        {
            _context.Groups.Update(group);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
