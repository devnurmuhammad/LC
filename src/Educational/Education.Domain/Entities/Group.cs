namespace Education.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public required string Number { get; set; }
        public int RoomId { get; set; }
        public ICollection<StudentGroup>? StudentGroups { get; set; }
        public ICollection<Teacher>? Teachers { get; set; }
    }
}