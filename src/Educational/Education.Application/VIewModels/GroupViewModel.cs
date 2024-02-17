namespace Education.Application.VIewModels
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public required string Number { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public required string Status { get; set; }
        public int RoomId { get; set; }
    }
}
