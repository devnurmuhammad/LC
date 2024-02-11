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
        //private readonly EducationDbContext
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
            //Student result = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
            //if (result is null)
            //{
                throw new Exception("not found");
            //}
        }

        public async Task<IList<StudentViewModel>> GetAllAsync()
        {
            IList<StudentViewModel> students = await _studentRepository.GetAllAsync();
            
            return students;
        }

        public Task<long> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<StudentViewModel> GetStudentById(int id)
        {
            StudentViewModel student = await _studentRepository.GetStudentById(id);
            
            return student;
        }

        public Task<bool> UpdateAsync(int id, StudentDTO student)
        {
            throw new NotImplementedException();
        }
    }
}
