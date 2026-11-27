using exam_system.Common.Interfaces;
using exam_system.Domain.Common;
using exam_system.Domain.Entities.Quizzes;
using exam_system.Domain.Entities.Enrollments;

namespace exam_system.Domain.Entities.Diplomas
{
    public class Diploma : BaseEntity<Guid> ,ISoftDeletable
    {
        public string Title { get; set; }
        public string ?Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();

    }
}
