using Education.Domain.Enums.GroupEnums;

namespace Education.Application.DTOs
{
    public class GroupDTO
    {
        public required string Number { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public GroupStatus Status { get; set; } = GroupStatus.Inactive;
        public int RoomId { get; set; }
    }
}
