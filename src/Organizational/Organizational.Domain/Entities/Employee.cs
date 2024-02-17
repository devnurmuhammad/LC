using Organizational.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Organizational.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Firstname { get; set; }
        public string? Middlename { get; set; }
        public required string Lastname { get; set; }
        public EmployeePosition Position { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string? Salary { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public string? Address { get; set; }
        public required string Passport { get; set; }
        public string? Comment { get; set; }
        public int? BranchId { get; set; }

        public ICollection<Contract>? Contracts { get; set; }
        public ICollection<EmployeeOutcome>? EmployeeOutcomes { get; set; }
        [ForeignKey(nameof(BranchId))]
        public Branch? Branch { get; set; }
    }
}
