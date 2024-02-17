using System.ComponentModel.DataAnnotations.Schema;

namespace Organizational.Domain.Entities
{
    public class Outcome
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public DateTime Date {  get; set; }
        public required string Amount { get; set; }
        public string? Other { get; set; }
        public int? BranchId { get; set; }
        
        public ICollection<EmployeeOutcome> Outcomes { get; set; }
        [ForeignKey(nameof(BranchId))]
        public Branch? Branch { get; set; }
    }
}
