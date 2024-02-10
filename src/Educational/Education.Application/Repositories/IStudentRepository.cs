using Education.Application.DTOs;
using Education.Application.VIewModels;
using Education.Domain.Entities;

namespace Education.Application.Repository
{
    public interface IStudentRepository
    {
        public Task<bool> CreateAsync(Student student);
        public Task<IList<StudentViewModel>> GetAllAsync();
        public Task<bool> UpdateAsync(int id, StudentDTO student);
        public Task<bool> DeleteAsync(int id);
        public Task<StudentViewModel> GetStudentById(int id);
        public Task<long> GetCountAsync();
    }
}
