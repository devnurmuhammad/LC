using Education.Domain.Entities;

namespace Education.Application.VIewModels
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public required string Firstname { get; set; }
        public required string Middlename { get; set; }
        public required string Lastname { get; set; }
        public string? Position { get; set; }
        public DateTime EmploymentDate { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public string? Address { get; set; }
        public required string Passport { get; set; }
        public string? Gender { get; set; }
        public required string Specialty { get; set; }

        public ICollection<TeacherSubject>? Subjects { get; set; }
    }
}
