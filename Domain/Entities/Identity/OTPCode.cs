using exam_system.Domain.Common;
using exam_system.Domain.Common.Interfaces;

namespace exam_system.Domain.Entities.Identity
{
    public class OtpCode : AuditableEntity<int>, ISoftDeletable
    {
        public string Email { get; set; } = string.Empty;

        public string CodeHash { get; set; } = string.Empty;

        public DateTime ExpiresAt { get; set; }

        public bool IsUsed { get; set; }

        public int AttemptCount { get; set; }

        public bool IsResend { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}
