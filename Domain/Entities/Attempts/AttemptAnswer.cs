using exam_system.Domain.Common;
using exam_system.Domain.Common.Interfaces;

namespace exam_system.Domain.Entities.Attempts
{
    public class AttemptAnswer : AuditableEntity<Guid> , ISoftDeletable
    {

        public Guid AttemptId { get; set; }

        public Guid AttemptQuestionId { get; set; }

        public Guid? SelectedOptionId { get; set; }
        public QuizAttempt Attempt { get; set; } = null!;

        public AttemptQuestion AttemptQuestion { get; set; } = null!;

        public AttemptOption? SelectedOption { get; set; }



        public DateTime AnsweredAt { get; set; }
        public bool? IsCoorect {  get; set; }
        bool IsDeletable { get; set; }
        DateTime? DeletedAt { get; set; }

    }
}
