using exam_system.Common.Interfaces;
using exam_system.Domain.Common;

namespace exam_system.Domain.Entities.Questions
{
    public class QuestionOption : BaseEntity<Guid> , ISoftDeletable
    {
       public bool IsCorrect { get; set; }
       public bool IsDeleted { get; set; }
       public DateTime? DeletedAt { get; set; }
       public int OrderIndex { get; set; }
       public Question Question { get; set; }
       public Option Option { get; set; }
       public Guid QuestionId { get; set; }
       public Guid OptionId { get; set; }

    }
}
