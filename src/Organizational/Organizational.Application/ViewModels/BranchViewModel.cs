using Organizational.Domain.Entities;

namespace Organizational.Application.ViewModels
{
    public class BranchViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string Phone { get; set; }
        public int CompanyId { get; set; }

        public ICollection<Income>? Incomes { get; set; }
        public ICollection<Outcome>? Outcomes { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
