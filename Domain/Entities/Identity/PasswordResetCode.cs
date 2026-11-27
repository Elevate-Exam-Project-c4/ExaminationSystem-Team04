using exam_system.Domain.Common;
using exam_system.Domain.Common.Interfaces;

namespace exam_system.Domain.Entities.Identity
{
    public class PasswordResetCode : AuditableEntity<int>, ISoftDeletable
    {
        public Guid UserId { get; set; }

        public string CodeHash { get; set; } = string.Empty;

        public DateTime ExpiresAt { get; set; }

        public int AttemptCount { get; set; }

        public bool IsUsed { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; }

        
        public ApplicationUser User { get; set; } = null!;
    }
}
