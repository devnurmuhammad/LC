using System.ComponentModel.DataAnnotations.Schema;

namespace Organizational.Domain.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string Phone { get; set; }

        public ICollection<Income>? Incomes { get; set; }
        public ICollection<Outcome>? Outcomes { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }
    }
}
