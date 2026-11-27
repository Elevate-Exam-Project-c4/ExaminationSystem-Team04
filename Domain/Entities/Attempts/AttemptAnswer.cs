using exam_system.Common.Interfaces;
using exam_system.Domain.Common;

namespace exam_system.Domain.Entities.Attempts
{
    public class AttemptAnswer : BaseEntity<int> , ISoftDeletable
    {

        public Guid AttemptId { get; set; }

        public Guid AttemptQuestionId { get; set; }

        public Guid? SelectedOptionId { get; set; }
        public QuizAttempt Attempt { get; set; } = null!;

        public AttemptQuestion AttemptQuestion { get; set; } = null!;

        public AttemptQuestionOptions? SelectedOption { get; set; }



        public DateTime AnsweredAt { get; set; }
        public bool? IsCorrect {  get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}
