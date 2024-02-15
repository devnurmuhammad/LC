using Education.Domain.Entities;

namespace Education.Application.Repositories
{
    public interface ISubjectRepository
    {
        public Task<bool> CreateAsync(Subject subject);
        public Task<IList<Subject>> GetAllAsync();
        public Task<bool> UpdateAsync(Subject subject);
        public Task<bool> DeleteAsync(string name);
        public Task<Subject> GetByNameAsync(string name);
        public Task<int> GetCountAsync();
    }
}
