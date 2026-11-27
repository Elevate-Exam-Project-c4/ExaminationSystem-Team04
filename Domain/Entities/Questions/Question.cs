using exam_system.Common.Interfaces;
using exam_system.Domain.Common;
using exam_system.Domain.Entities.Attempts;
using exam_system.Domain.Entities.Quizzes;

namespace exam_system.Domain.Entities.Questions
{
    public class Question : BaseEntity<Guid> , ISoftDeletable
    {
        public string Text { get; set; }
        public string ? Explaination {  get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
       = new List<QuestionOption>();
        public ICollection<QuizQuestion> QuizQuestions { get; set; }
      = new List<QuizQuestion>();

        public ICollection<AttemptQuestion> AttemptQuestions { get; set; } = new List<AttemptQuestion>();
    }
}
