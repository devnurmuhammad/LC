using System.ComponentModel.DataAnnotations.Schema;

namespace Education.Domain.Entities
{
    public class TeacherGroup
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int GroupId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }
        [ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }
    }
}
