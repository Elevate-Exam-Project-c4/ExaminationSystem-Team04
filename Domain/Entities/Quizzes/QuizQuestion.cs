using exam_system.Common.Interfaces;
using exam_system.Domain.Common;
using exam_system.Domain.Entities.Questions;

namespace exam_system.Domain.Entities.Quizzes
{
    public class QuizQuestion : BaseEntity<Guid> , ISoftDeletable
    {
        public int OrderIndex { get; set; }
        public Question Question {  get; set; }
        public Quiz Quiz { get; set; }
        public Guid QuestionId {get;set;}
        public Guid QuizId { get;set;}


        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
