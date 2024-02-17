using Organizational.Domain.Enums;

namespace Organizational.Application.DTOs
{
    public class EmployeeDTO
    {
        public required string Firstname { get; set; }
        public string? Middlename { get; set; }
        public required string Lastname { get; set; }
        public EmployeePosition Position { get; set; }
        public DateTime EmploymentDate { get; set; }
        public bool IsActive { get; set; }
        public string? Salary { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public string? Address { get; set; }
        public required string Passport { get; set; }
        public string? Comment { get; set; }
        public int? BranchId { get; set; }
    }
}
