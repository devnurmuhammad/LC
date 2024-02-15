using Education.Application.Repositories;
using Education.Domain.Entities;
using Education.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Education.Infrastructure.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly EducationDbContext _context;
        public SubjectRepository(EducationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Subject subject)
        {
            await _context.Subjects.AddAsync(subject);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteAsync(string name)
        {
            Subject subject = await _context.Subjects.FirstOrDefaultAsync(subject => subject.Name == name);
            _context.Subjects.Remove(subject);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<IList<Subject>> GetAllAsync()
        {
            IList<Subject> subjects = await _context.Subjects.ToListAsync();

            return subjects;
        }

        public async Task<Subject> GetByNameAsync(string name)
        {
            Subject subject = await _context.Subjects.FirstOrDefaultAsync(s => s.Name == name);

            return subject;
        }

        public async Task<int> GetCountAsync()
        {
            int count = await _context.Subjects.CountAsync();

            return count;
        }

        public async Task<bool> UpdateAsync(Subject subject)
        {
            _context.Subjects.Update(subject);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
