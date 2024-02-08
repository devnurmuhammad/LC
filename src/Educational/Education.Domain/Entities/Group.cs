using Education.Domain.Enums.GroupEnums;

namespace Education.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public required string Number { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public GroupStatus Status { get; set; }
        public int RoomId { get; set; }
        public ICollection<StudentGroup>? StudentGroups { get; set; }
        public ICollection<Teacher>? Teachers { get; set; }
    }
}