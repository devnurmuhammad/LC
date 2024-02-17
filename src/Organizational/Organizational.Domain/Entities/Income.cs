using System.ComponentModel.DataAnnotations.Schema;

namespace Organizational.Domain.Entities
{
    public class Income
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public DateTime Date { get; set; }
        public required string Amount { get; set; }
        public int BranchId { get; set; }
        public int ContractId { get; set; }

        [ForeignKey(nameof(BranchId))]
        public required Branch Branch { get; set; }
        [ForeignKey(nameof(ContractId))]
        public Contract? Contract { get; set; }
    }
}
