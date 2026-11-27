using exam_system.Common.Interfaces;
using exam_system.Domain.Common;

namespace exam_system.Domain.Entities.Identity
{
    public class RefreshToken : BaseEntity<int>, ISoftDeletable
    {
        public Guid UserId { get; set; }

        public string TokenHash { get; set; } = string.Empty;

        public DateTime ExpiresAt { get; set; }

        public bool IsUsed { get; set; }

        public bool IsRevoked { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; }

        
        public ApplicationUser User { get; set; } = null!;
    }
}
