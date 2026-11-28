using exam_system.Domain.Entities.Attempts;
using exam_system.Domain.Entities.Diplomas;
using exam_system.Domain.Entities.Enrollments;
using exam_system.Domain.Entities.Identity;
using exam_system.Domain.Entities.Quizzes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace exam_system.Persistence.Context;

public class AppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }
    //Identity DbSets
    public DbSet<OtpCode> OtpCodes { get; set; }
    public DbSet<PasswordResetCode> PasswordResetCodes { get; set; }
    public DbSet<PasswordResetToken> PasswordResetTokens { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }

    //Diploma 
    public DbSet<Diploma> Diplomas { get; set; }

    //Enrollment
    public DbSet<Enrollment> Enrollments { get; set; }
    //Quiz
    public DbSet<Quiz> Quizzes { get; set; }

    // Attempts Tables
    public DbSet<QuizAttempt> QuizAttempts { get; set; }
    public DbSet<AttemptQuestion> AttemptQuestion { get; set; }
    public DbSet<AttemptQuestionOptions> AttemptQuestionOptions { get; set; }
    public DbSet<AttemptAnswer> AttemptAnswer { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly
        );
    }

}
