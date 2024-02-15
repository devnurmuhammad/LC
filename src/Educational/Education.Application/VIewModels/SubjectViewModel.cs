namespace Education.Application.VIewModels
{
    public class SubjectViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Duration { get; set; }
    }
}
