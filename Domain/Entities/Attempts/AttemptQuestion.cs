using exam_system.Domain.Common;
using exam_system.Domain.Entities.Question;

namespace exam_system.Domain.Entities.Attempts
{
    public class AttemptQuestion : AuditableEntity<Guid>
    {
        public Guid? OriginalQuestionId {  get; set; }
        public Guid AttemptId { get;set; }
        public string QuestionText { get; set; }
        public string ?Explanation { get; set; }
        public int OrderIndex { get; set; }
        public QuizAttempt Attempt { get; set; }
        
        public ICollection<AttemptOption> Options { get; set; }
       = new List<AttemptOption>();
        public ICollection<AttemptAnswer> Answers { get; set; }
       = new List<AttemptAnswer>();
    }
}
