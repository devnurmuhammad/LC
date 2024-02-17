namespace Organizational.Application.DTOs
{
    public class OutcomeDTO
    {
        public required string Description { get; set; }
        public DateTime Date { get; set; }
        public required string Amount { get; set; }
        public string? Other { get; set; }
        public int? BranchId { get; set; }
    }
}
