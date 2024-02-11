using Education.Application.DTOs;
using Education.Application.Repository;
using Education.Application.VIewModels;
using Education.Domain.Entities;
using Education.Domain.Enums;
using Education.Domain.Enums.StudentEnums;
using Education.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Education.Infrastructure.Repositories.Students
{
    public class StudentRepository : IStudentRepository
    {
        private readonly EducationDbContext _context;

        public StudentRepository(EducationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            int reslut = await _context.SaveChangesAsync();

            return reslut > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Student result = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (result is null)
            {
                throw new Exception("not found");
            }
            _context.Students.Remove(result);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IList<StudentViewModel>> GetAllAsync()
        {
            IList<Student> students = await _context.Students.Include(x => x.StudentGroups)
                .ToListAsync();
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

        public Task<long> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<StudentViewModel> GetStudentById(int id)
        {
            Student student = await _context.Students.Include(x => x.StudentGroups)
                .FirstOrDefaultAsync(y => y.Id == id);

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

        public Task<bool> UpdateAsync(int id, StudentDTO student)
        {
            throw new NotImplementedException();
        }
    }
}
