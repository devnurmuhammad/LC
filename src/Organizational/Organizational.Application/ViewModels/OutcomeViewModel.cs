using Organizational.Domain.Entities;

namespace Organizational.Application.ViewModels
{
    public class OutcomeViewModel
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public DateTime Date { get; set; }
        public required string Amount { get; set; }
        public string? Other { get; set; }
        public int? BranchId { get; set; }

        public ICollection<EmployeeOutcome> Outcomes { get; set; }
    }
}
