using exam_system.Domain.Common;
using exam_system.Domain.Common.Interfaces;
using exam_system.Domain.Entities.Quiz;

namespace exam_system.Domain.Entities.Question
{
    public class Question : AuditableEntity<Guid> , ISoftDeletable
    {
        public string Text { get; set; }
        public string ? Explaination {  get; set; }
        public bool IsDeletable { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
       = new List<QuestionOption>();
        public ICollection<QuizQuestion> QuizQuestions { get; set; }
      = new List<QuizQuestion>();
    }
}
