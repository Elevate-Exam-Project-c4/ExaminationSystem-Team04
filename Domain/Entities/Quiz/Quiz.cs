using exam_system.Domain.Common;
using exam_system.Domain.Common.Enums;
using exam_system.Domain.Common.Interfaces;
using exam_system.Domain.Entities.Attempts;
using exam_system.Domain.Entities.Diplomas;

namespace exam_system.Domain.Entities.Quiz
{
    public class Quiz :AuditableEntity<Guid> ,ISoftDeletable
    {
        public Guid DiplomaId { get; set; }
        public Diploma Diploma { get; set; }
        public string Title { get; set; }
        public string ?Instructions { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public int DurationMintues { get; set; }
        public decimal PassScore { get; set; } = 60;
        public int ? MaxAttempts {get;set;}
        public QuizStatus Status { get; set; } = QuizStatus.draft;
        public DateTime ?PublishedAt {  get; set; }


        bool IsDeletable { get; set; }
        DateTime? DeletedAt { get; set; }
        public ICollection<QuizQuestion> QuizQuestions { get; set; }
      = new List<QuizQuestion>();

        public ICollection<QuizAttempt> QuizAttempts { get; set; }
       = new List<QuizAttempt>();
    }
}
