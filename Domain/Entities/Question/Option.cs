using exam_system.Domain.Common;
using exam_system.Domain.Common.Interfaces;
using exam_system.Domain.Entities.Attempts;

namespace exam_system.Domain.Entities.Question
{
    public class Option : AuditableEntity<Guid>, ISoftDeletable
    {
        public string Text { get; set; }
        public bool IsDeletable { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
       = new List<QuestionOption>();

        public ICollection<AttemptOption> AttemptOption { get; set; }
    }
}
