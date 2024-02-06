using Education.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Education.Infrastructure.Data
{
    public class EducationDbContext : DbContext
    {
        public EducationDbContext(DbContextOptions<EducationDbContext> options) : base(options)
        {
            Database.Migrate();
        }


        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherSubject> TeachersSubjects { get; set; }
    }
}
