using Education.Domain.Entities;

namespace Education.Application.Repository
{
    public interface IStudentRepository
    {
        public Task<bool> CreateAsync(Student student);
        public Task<IList<Student>> GetAllAsync();
        public Task<bool> UpdateAsync(Student student);
        public Task<bool> DeleteAsync(int id);
        public Task<Student> GetStudentById(int id);
        public Task<long> GetCountAsync();
    }
}
