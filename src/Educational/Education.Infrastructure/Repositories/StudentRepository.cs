using Education.Application.Repository;
using Education.Domain.Entities;
using Education.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Education.Infrastructure.Repositories
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
        public async Task<IList<Student>> GetAllAsync()
        {
            IList<Student> students = await _context.Students.Include(x => x.StudentGroups)
                .ToListAsync();

            return students;
        }
        public async Task<bool> UpdateAsync(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            Student result = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
            _context.Students.Remove(result);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<long> GetCountAsync()
        {
            long result = await _context.Students.CountAsync();
            return result;
        }
        public async Task<Student> GetStudentById(int id)
        {
            Student student = await _context.Students.Include(x => x.StudentGroups)
                .FirstOrDefaultAsync(y => y.Id == id);

            return student;
        }
    }
}
