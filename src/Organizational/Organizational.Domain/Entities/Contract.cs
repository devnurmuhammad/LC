using System.ComponentModel.DataAnnotations.Schema;

namespace Organizational.Domain.Entities
{
    public class Contract
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime UpdateAt { get; set; }
        public int? UpdateEmployeeId { get; set; }
        public string? Comment { get; set; } 
        public required string Amount { get; set; }
        public required int EmployeeId { get; set; }
        //public required int StudentId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public required Employee Employee { get; set; }
        public Income Income { get; set; }
    }
}
