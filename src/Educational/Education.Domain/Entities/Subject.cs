namespace Education.Domain.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Duration { get; set; }
        public ICollection<TeacherSubject>? Teachers { get; set; }
    }
}
