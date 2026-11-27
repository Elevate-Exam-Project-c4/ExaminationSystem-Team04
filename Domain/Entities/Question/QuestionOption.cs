using exam_system.Domain.Common;
using exam_system.Domain.Common.Interfaces;

namespace exam_system.Domain.Entities.Question
{
    public class QuestionOption : AuditableEntity<Guid> , ISoftDeletable
    {
       public bool IsCorrect { get; set; }
       public bool IsDeletable { get; set; }
       public DateTime? DeletedAt { get; set; }
       public int OrderIndex { get; set; }
       public Question Question { get; set; }
       public Option Option { get; set; }
       public Guid QuestionId { get; set; }
       public Guid OptionId { get; set; }

    }
}
