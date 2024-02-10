using Education.Application.DTOs;
using Education.Application.Interfaces;
using Education.Application.Repository;
using Education.Application.VIewModels;
using Education.Domain.Entities;

namespace Education.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<bool> CreateAsync(StudentDTO dto)
        {
            Student student = new Student()
            {
                Firstname = dto.Firstname,
                Lastname = dto.Lastname,
                Middlename = dto.Middlename,
                Address = dto.Address,
                Email = dto.Email,
                Phone = dto.Phone,
                Gender = dto.Gender,
                Course = dto.Course,
                Status = dto.Status,
                Comment = dto.Comment,
            };
            bool result = await _studentRepository.CreateAsync(student);
            return result;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<StudentViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<long> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StudentViewModel> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, StudentDTO student)
        {
            throw new NotImplementedException();
        }
    }
}
