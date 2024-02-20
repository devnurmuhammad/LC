namespace Organizational.Application.DTOs
{
    public class CompanyDTO
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string Website { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public string? CEO { get; set; }
    }
}