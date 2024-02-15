using Education.Application.DTOs;
using Education.Application.VIewModels;

namespace Education.Application.Interfaces
{
    public interface ISubjectService
    {
        public Task<bool> CreateAsync(SubjectDTO subjectDTO);
        public Task<IList<SubjectViewModel>> GetAllAsync();
        public Task<bool> UpdateAsync(string name, SubjectDTO subjectDTO);
        public Task<bool> DeleteAsync(string name);
        public Task<SubjectViewModel> GetByNameAsync(string name);
        public Task<int> GetCountAsync();
    }
}
