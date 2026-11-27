using exam_system.Domain.Common;
using exam_system.Domain.Common.Interfaces;
using exam_system.Domain.Entities.Quiz;

namespace exam_system.Domain.Entities.Diplomas
{
    public class Diploma : AuditableEntity<Guid> ,ISoftDeletable
    {
        public string Title { get; set; }
        public string ?Description { get; set; }
        public bool IsDeletable { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<Enrollement> Enrollements { get; set; } = new List<Enrollement>();
        public ICollection<Quiz> Quizess { get; set; } = new List<Quiz>();

    }
}
