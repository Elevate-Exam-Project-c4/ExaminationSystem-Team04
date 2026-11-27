using exam_system.Domain.Common;
using exam_system.Domain.Entities.Question;

namespace exam_system.Domain.Entities.Attempts
{
    public class AttemptOption : AuditableEntity<Guid>
    {
        public bool IsCorrect { get; set; }
        public string OptionText { get; set; }
        public int OptionOrder { get; set; }
        public AttemptQuestion AttemptQuestion { get; set; }
        public Guid AttemptQuestionId { get; set; }
        public Guid OriginalOptionId { get; set; }
        public ICollection<AttemptAnswer> Answers { get; set; }
       = new List<AttemptAnswer>();

        public Option OriginalOption { get;set;}

    }
}
