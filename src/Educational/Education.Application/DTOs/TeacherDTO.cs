using Education.Domain.Enums;
using Education.Domain.Enums.TeacherEnums;

namespace Education.Application.DTOs
{
    public class TeacherDTO
    {
        public required string Firstname { get; set; }
        public required string Middlename { get; set; }
        public required string Lastname { get; set; }
        public TeacherPosition Position { get; set; }
        public DateTime EmploymentDate { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public string? Address { get; set; }
        public required string Passport { get; set; }
        public GenderEnum Gender { get; set; }
        public required string Specialty { get; set; }
    }
}
