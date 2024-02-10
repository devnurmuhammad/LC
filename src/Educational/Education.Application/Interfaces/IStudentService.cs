using Education.Application.DTOs;
using Education.Application.VIewModels;
using Education.Domain.Entities;

namespace Education.Application.Interfaces
{
    public interface IStudentService
    {
        public Task<bool> CreateAsync(StudentDTO student);
        public Task<IList<StudentViewModel>> GetAllAsync();
        public Task<bool> UpdateAsync(int id, StudentDTO student);
        public Task<bool> DeleteAsync(int id);
        public Task<StudentViewModel> GetStudentById(int id);
        public Task<long> GetCountAsync(); 
    }
}
