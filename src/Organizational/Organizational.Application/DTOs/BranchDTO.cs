namespace Organizational.Application.DTOs
{
    public class BranchDTO
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string Phone { get; set; }
        public int CompanyId { get; set; }
    }
}
