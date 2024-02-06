using System.ComponentModel.DataAnnotations.Schema;

namespace Education.Domain.Entities
{
    public class StudentGroup
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int StudentId { get; set; }

        [ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }
    }
}
