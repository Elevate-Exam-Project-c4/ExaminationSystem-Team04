using exam_system.Common.Interfaces;
using exam_system.Domain.Common;
using exam_system.Domain.Entities.Attempts;

namespace exam_system.Domain.Entities.Questions
{
    public class Option : BaseEntity<Guid>, ISoftDeletable
    {
        public string Text { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
       = new List<QuestionOption>();

        public ICollection<AttemptQuestionOptions> AttemptOption { get; set; }
    }
}
