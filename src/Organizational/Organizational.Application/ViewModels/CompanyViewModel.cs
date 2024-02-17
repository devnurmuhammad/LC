using Organizational.Domain.Entities;

namespace Organizational.Application.ViewModels
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string Website { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public string? CEO { get; set; }
        public ICollection<Branch> Branches { get; set; }
    }
}
