using System.ComponentModel.DataAnnotations.Schema;

namespace Organizational.Domain.Entities
{
    public class EmployeeOutcome
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int OutcomeId { get; set; }

        [ForeignKey(nameof(OutcomeId))]
        public required Outcome Outcome { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public required Employee Employee { get; set; }
    }
}
