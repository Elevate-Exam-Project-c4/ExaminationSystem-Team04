using exam_system.Domain.Common;
using exam_system.Domain.Common.Interfaces;

namespace exam_system.Domain.Entities.Quiz
{
    public class QuizQuestion : AuditableEntity<Guid> , ISoftDeletable
    {
        public int OrderIndex { get; set; }
        public Question Question {  get; set; }
        public Quiz Quiz { get; set; }
        public Guid QuestionId {get;set;}
        public Guid QuizId { get;set;}


        bool IsDeletable { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}
