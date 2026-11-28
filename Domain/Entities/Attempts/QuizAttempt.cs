using exam_system.Common.Enums;
using exam_system.Common.Interfaces;
using exam_system.Domain.Common;
using exam_system.Domain.Entities.Identity;
using exam_system.Domain.Entities.Quizzes;

namespace exam_system.Domain.Entities.Attempts
{
    public class QuizAttempt : BaseEntity<Guid> , ISoftDeletable
    {
        public Guid StudentId { get; set; }
        public Guid QuizId { get; set; }
        public ApplicationUser Student { get; set; }
        public Quiz Quiz { get; set; }

        public QuizAttemptStatus Status = QuizAttemptStatus.InProgress;
        public DateTime AttemptStartDate { get; set; }
        public DateTime AttemptDeadline {  get; set; }
        public int NavigationVersion { get; set; } = 0;
        public int CurrentQuestionIndex { get; set; } = 0;
        public DateTime? SubmittedAt {  get; set; }
        public decimal AttemptScore { get; set; }
        public bool IsPassed { get; set; }
        public decimal PassScoreSnapShot { get; set; }
        public string QuizTitleSnapShot { get; set; }


      public  bool IsDeleted { get; set; }
      public DateTime? DeletedAt { get; set; }
        public ICollection<AttemptQuestion> Questions { get; set; }
     = new List<AttemptQuestion>();

        public ICollection<AttemptAnswer> Answers { get; set; }
            = new List<AttemptAnswer>();


    }
}
