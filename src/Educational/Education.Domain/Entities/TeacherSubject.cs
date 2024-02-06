using System.ComponentModel.DataAnnotations.Schema;

namespace Education.Domain.Entities
{
    public class TeacherSubject
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }
    }
}
