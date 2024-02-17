namespace Organizational.Application.ViewModels
{
    public class IncomeViewModel
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public DateTime Date { get; set; }
        public required string Amount { get; set; }
        public int BranchId { get; set; }
        public int ContractId { get; set; }
    }
}
