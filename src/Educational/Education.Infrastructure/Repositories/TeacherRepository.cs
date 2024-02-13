using Education.Application.Repositories;
using Education.Domain.Entities;
using Education.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Education.Infrastructure.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly EducationDbContext _context;

        public TeacherRepository(EducationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Teacher teacher)
        {
            await _context.Teachers.AddAsync(teacher);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Teacher teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == id);
            _context.Teachers.Remove(teacher);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<IList<Teacher>> GetAllAsync()
        {
            IList<Teacher> teachers = await _context.Teachers.Include(x => x.Subjects).ToListAsync();

            return teachers;
        }

        public async Task<long> GetCountAsync()
        {
            long count = await _context.Teachers.CountAsync();

            return count;
        }

        public async Task<Teacher> GetTeacherById(int id)
        {
            Teacher teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == id);

            return teacher;
        }

        public async Task<bool> UpdateAsync(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
