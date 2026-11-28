using exam_system.Domain.Entities.Attempts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.AttemptConfiguration
{
    public class QuizAttemptConfiguration : IEntityTypeConfiguration<QuizAttempt>
    {
        public void Configure(EntityTypeBuilder<QuizAttempt> builder)
        {
            builder.ToTable("QuizAttempts");
            builder.HasKey(x => x.Id);

            // Properties
            builder.Property(x => x.Status)
                .HasConversion<string>()
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.AttemptStartDate)
                .IsRequired();

            builder.Property(x => x.AttemptDeadline)
                .IsRequired();

            builder.Property(x => x.SubmittedAt)
                .IsRequired(false);

            builder.Property(x => x.NavigationVersion)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(x => x.CurrentQuestionIndex)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(x => x.AttemptScore)
                .HasPrecision(5, 2)
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(x => x.IsPassed)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.PassScoreSnapShot)
                .HasPrecision(5, 2)
                .IsRequired();

            builder.Property(x => x.QuizTitleSnapShot)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.DeletedAt)
                .IsRequired(false);

            // Relationships
            builder.HasOne(x => x.Student)
                .WithMany()
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Quiz)
                .WithMany()
                .HasForeignKey(x => x.QuizId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Questions)
                .WithOne(x => x.Attempt)
                .HasForeignKey(x => x.AttemptId)
                .OnDelete(DeleteBehavior.Cascade);

            // Indexes
            builder.HasIndex(x => x.StudentId);
            builder.HasIndex(x => x.QuizId);
            builder.HasIndex(x => new { x.StudentId, x.QuizId });

        }

    }
}
