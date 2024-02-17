namespace Organizational.Application.ViewModels
{
    public class ContractViewModel
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime PaymentDate { get; set; }
        public required string Amount { get; set; }
        public DateTime UpdateAt { get; set; }
        public string? Comment { get; set; }
        public int? UpdateEmployeeId { get; set; }
        public required int EmployeeId { get; set; }
    }
}
