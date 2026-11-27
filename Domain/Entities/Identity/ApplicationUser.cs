using exam_system.Domain.Common.Enums;
using exam_system.Domain.Common.Interfaces;
using exam_system.Domain.Entities.Attempts;
using exam_system.Domain.Entities.Enrollement;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
namespace exam_system.Domain.Entities.Identity
{
    public class ApplicationUser : IdentityUser<Guid>, IEntity<Guid>, ISoftDeletable
    {
       
        public string FullName { get; set; } = string.Empty;

      
        public UserRole Role { get; set; } = UserRole.Student;

        public AccountStatus AccountStatus { get; set; } =
            AccountStatus.Pending;

      
        public DateTime? LastActivityAt { get; set; }

        
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        
        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; }

      
        public ICollection<RefreshToken> RefreshTokens { get; set; }
            = new List<RefreshToken>();

        public ICollection<PasswordResetCode> PasswordResetCodes { get; set; }
            = new List<PasswordResetCode>();

        public ICollection<PasswordResetToken> PasswordResetTokens { get; set; }
            = new List<PasswordResetToken>();

        
        public ICollection<Enrollment> Enrollments { get; set; }
            = new List<Enrollment>();

        
        public ICollection<QuizAttempt> QuizAttempts { get; set; }
            = new List<QuizAttempt>();
    }
}
