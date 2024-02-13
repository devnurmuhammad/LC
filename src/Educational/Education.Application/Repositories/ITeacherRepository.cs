using Education.Domain.Entities;

namespace Education.Application.Repositories
{
    public interface ITeacherRepository
    {
        public Task<bool> CreateAsync(Teacher teacher);
        public Task<IList<Teacher>> GetAllAsync();
        public Task<bool> UpdateAsync(Teacher teacher);
        public Task<bool> DeleteAsync(int id);
        public Task<Teacher> GetTeacherById(int id);
        public Task<long> GetCountAsync();
    }
}
