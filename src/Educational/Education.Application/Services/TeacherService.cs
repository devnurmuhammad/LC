using Education.Application.DTOs;
using Education.Application.Interfaces;
using Education.Application.Repositories;
using Education.Application.VIewModels;
using Education.Domain.Entities;
using Education.Domain.Enums;
using Education.Domain.Enums.TeacherEnums;

namespace Education.Application.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repository;

        public TeacherService(ITeacherRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> CreateAsync(TeacherDTO teacherDTO)
        {
            Teacher teacher = new Teacher()
            {
                Firstname = teacherDTO.Firstname,
                Middlename = teacherDTO.Middlename,
                Lastname = teacherDTO.Lastname,
                Address = teacherDTO.Address,
                Email = teacherDTO.Email,
                Phone = teacherDTO.Phone,
                Passport = teacherDTO.Passport,
                Gender = teacherDTO.Gender,
                EmploymentDate = DateTime.UtcNow,
                Position = teacherDTO.Position,
                Specialty = teacherDTO.Specialty,
            };

            bool result = await _repository.CreateAsync(teacher);

            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Teacher teacher = await _repository.GetTeacherById(id);
            if (teacher == null)
                throw new Exception("Not found");

            await _repository.DeleteAsync(id);

            return true;
        }

        public async Task<IList<TeacherViewModel>> GetAllAsync()
        {
            IList<Teacher> teachers = await _repository.GetAllAsync();
            IList<TeacherViewModel> result = teachers.Select(x => new TeacherViewModel
            {
                Id = x.Id,
                Firstname = x.Firstname,
                Middlename = x.Middlename,
                Lastname = x.Lastname,
                Address = x.Address,
                Email = x.Email,
                Phone = x.Phone,
                Passport = x.Passport,
                Gender = Enum.GetName(typeof(GenderEnum), (int)x.Gender),
                Specialty = x.Specialty,
                EmploymentDate = x.EmploymentDate,
                Position = Enum.GetName(typeof(TeacherPosition), (int)x.Position),
                Subjects = x.Subjects,
            }).ToList();

            return result;
        }

        public async Task<long> GetCountAsync()
        {
            long count = await _repository.GetCountAsync();

            return count;
        }

        public async Task<TeacherViewModel> GetTeacherByIdAsync(int id)
        {
            Teacher teacher = await _repository.GetTeacherById(id);
            if (teacher == null)
                throw new Exception("Not found");

            TeacherViewModel result = new TeacherViewModel()
            {
                Id = teacher.Id,
                Firstname = teacher.Firstname,
                Middlename = teacher.Middlename,
                Lastname = teacher.Lastname,
                Address = teacher.Address,
                Email = teacher.Email,
                Phone = teacher.Phone,
                Passport = teacher.Passport,
                EmploymentDate = teacher.EmploymentDate,
                Gender = Enum.GetName(typeof(GenderEnum), (int)teacher.Gender),
                Position = Enum.GetName(typeof(TeacherPosition), (int)teacher.Position),
                Specialty = teacher.Specialty,
                Subjects = teacher.Subjects,
            };

            return result;
        }

        public async Task<bool> UpdateAsync(int id, TeacherDTO teacherDTO)
        {
            Teacher teacher = await _repository.GetTeacherById(id);
            if (teacher == null)
                throw new Exception("Not found");

            teacher.Firstname = teacherDTO.Firstname;
            teacher.Middlename = teacherDTO.Middlename;
            teacher.Lastname = teacherDTO.Lastname;
            teacher.Address = teacherDTO.Address;
            teacher.Phone = teacherDTO.Phone;
            teacher.Passport = teacherDTO.Passport;
            teacher.Position = teacherDTO.Position;
            teacher.Specialty = teacherDTO.Specialty;
            teacher.Email = teacherDTO.Email;
            teacher.EmploymentDate = teacherDTO.EmploymentDate;
            teacher.Gender = teacherDTO.Gender;

            bool result = await _repository.UpdateAsync(teacher);

            return result;
        }
    }
}
