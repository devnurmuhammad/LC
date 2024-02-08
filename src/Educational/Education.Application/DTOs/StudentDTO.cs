using Education.Domain.Enums.StudentEnums;

namespace Education.Application.DTOs
{
    public class StudentDTO
    {
        public required string Firstname { get; set; }
        public required string Middlename { get; set; }
        public required string Lastname { get; set; }
        public string? Address { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public bool Status { get; set; }
        public StudentCourse? Course { get; set; }
        public string? Comment { get; set; }
    }
}
