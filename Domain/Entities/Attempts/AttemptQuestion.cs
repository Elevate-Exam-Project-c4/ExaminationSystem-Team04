using exam_system.Domain.Common;
using exam_system.Domain.Entities.Questions;

namespace exam_system.Domain.Entities.Attempts
{
    public class AttemptQuestion : BaseEntity<Guid>
    {
        public Guid? OriginalQuestionId {  get; set; }
        public Guid AttemptId { get;set; }
        public string QuestionText { get; set; }
        public string ?Explanation { get; set; }
        public int OrderIndex { get; set; } 
        public QuizAttempt Attempt { get; set; }
        
        public ICollection<AttemptQuestionOptions> Options { get; set; }
       = new List<AttemptQuestionOptions>();
        public AttemptAnswer? Answer { get; set; }

        public Questions.Question OriginalQuestion { get; set; }
    }
}
