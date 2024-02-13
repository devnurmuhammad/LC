using Education.Application.DTOs;
using Education.Application.VIewModels;

namespace Education.Application.Interfaces
{
    public interface ITeacherService
    {
        public Task<bool> CreateAsync(TeacherDTO teacherDTO);
        public Task<IList<TeacherViewModel>> GetAllAsync();
        public Task<bool> UpdateAsync(int id, TeacherDTO teacherDTO);
        public Task<bool> DeleteAsync(int id);
        public Task<TeacherViewModel> GetTeacherByIdAsync(int id);
        public Task<long> GetCountAsync();
    }
}
