using exam_system.Domain.Common;
using exam_system.Domain.Common.Interfaces;
using exam_system.Domain.Entities.Diplomas;
using exam_system.Domain.Entities.Identity;

namespace exam_system.Domain.Entities.Enrollement
{
    public class Enrollement : AuditableEntity<int>, ISoftDeletable
    {
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
        public ApplicationUser Student { get; set; }
        public Diploma Diploma { get; set; }
        public Guid StudentId {  get; set; }
        public Guid DiplomaId { get; set; }
        public DateTime ? EnrolledAt { get; set; }
    }
}
