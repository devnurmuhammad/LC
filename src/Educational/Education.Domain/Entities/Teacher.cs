using Education.Domain.Enums.TeacherEnums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Education.Domain.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public required string Firstname { get; set; }
        public required string Middlename { get; set; }
        public required string Lastname { get; set; }
        public TeacherPosition Position { get; set; }
        public DateTime EmploymentDate { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public string? Address { get; set; }
        public required string Passport { get; set; }
        public required string Specialty { get; set; }
        public int GroupId { get; set; }

        public ICollection<TeacherSubject> Subjects { get; set; }
        [ForeignKey(nameof(GroupId))]
        public Group? Group { get; set; }
    }
}