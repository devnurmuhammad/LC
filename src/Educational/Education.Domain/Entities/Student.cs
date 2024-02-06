namespace Education.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public required string Firstname { get; set; }
        public required string Middlename { get; set; }
        public required string Lastname { get; set; }
        public string? Address { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public bool Status { get; set; }
        public string? Comment { get; set; }
        public int BranchId { get; set; }
        public ICollection<StudentGroup>? StudentGroups { get; set; }
    }
}
