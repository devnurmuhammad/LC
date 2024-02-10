using Education.Application.DTOs;
using Education.Application.Repository;
using Education.Application.VIewModels;
using Education.Domain.Entities;
using Education.Infrastructure.Data;

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
