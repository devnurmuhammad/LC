using Education.Application.DTOs;
using Education.Application.Interfaces;
using Education.Application.Repository;
using Education.Application.VIewModels;
using Education.Domain.Entities;
using Education.Domain.Enums;
using Education.Domain.Enums.StudentEnums;

#nullable disable

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

        public async Task<bool> DeleteAsync(int id)
        {
            Student student = await _studentRepository.GetStudentById(id);
            if (student == null)
            {
                throw new Exception("Not found");
            }
            await _studentRepository.DeleteAsync(id);

            return true;
        }

        public async Task<IList<StudentViewModel>> GetAllAsync()
        {
            IList<Student> students = await _studentRepository.GetAllAsync();
            IList<StudentViewModel> result = students.Select(x => new StudentViewModel
            {
                Id = x.Id,
                Firstname = x.Firstname,
                Middlename = x.Middlename,
                Lastname = x.Lastname,
                Address = x.Address,
                Gender = Enum.GetName(typeof(GenderEnum), (int)x.Gender),
                Phone = x.Phone,
                Email = x.Email,
                Status = x.Status ? "faol" : "nofaol",
                Course = Enum.GetName(typeof(StudentCourse), (int)x.Course),
                Comment = x.Comment,
                BranchId = x.BranchId,
                StudentGroups = x.StudentGroups,
            }).ToList();

            return result;
        }

        public async Task<long> GetCountAsync()
        {
            long result = await _studentRepository.GetCountAsync();
            return result;
        }

        public async Task<StudentViewModel> GetStudentById(int id)
        {
            Student student = await _studentRepository.GetStudentById(id);
            if (student == null)
            {
                throw new Exception("not found");
            }
            StudentViewModel result = new StudentViewModel()
            {
                Id = student.Id,
                Firstname = student.Firstname,
                Middlename = student.Middlename,
                Lastname = student.Lastname,
                Address = student.Address,
                Gender = Enum.GetName(typeof(GenderEnum), (int)student.Gender),
                Phone = student.Phone,
                Email = student.Email,
                Status = student.Status ? "faol" : "nofaol",
                Course = Enum.GetName(typeof(StudentCourse), (int)student.Course),
                Comment = student.Comment,
                BranchId = student.BranchId,
                StudentGroups = student.StudentGroups,
            };

            return result;
        }

        public async Task<bool> UpdateAsync(int id, StudentDTO studentDTO)
        {
            Student student = await _studentRepository.GetStudentById(id);
            if (student == null)
            {
                throw new Exception("Not found");
            }
            student.Firstname = studentDTO.Firstname;
            student.Middlename = studentDTO.Middlename;
            student.Lastname = studentDTO.Lastname;
            student.Address = studentDTO.Address;
            student.Gender = studentDTO.Gender;
            student.Phone = studentDTO.Phone;
            student.Email = studentDTO.Email;
            student.Status = studentDTO.Status;
            student.Course = studentDTO.Course;
            student.Comment = studentDTO.Comment;
            student.BranchId = studentDTO.BranchId;

            bool result = await _studentRepository.UpdateAsync(student);

            return result;
        }
    }
}