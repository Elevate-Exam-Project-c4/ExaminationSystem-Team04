using exam_system.Common.Enums;
using exam_system.Domain.Entities.Quizzes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.QuizConfig
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.ToTable("Quizzes");

            builder.HasKey(q => q.Id);

            builder.Property(q => q.Id)
                   .HasDefaultValueSql("NEWID()")
                   .ValueGeneratedOnAdd();

            builder.Property(q => q.DiplomaId)
                   .IsRequired();

            builder.Property(q => q.Title)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(q => q.Instructions)
                   .IsRequired(false);

            builder.Property(q => q.StartDate)
                   .HasColumnType("datetime2")
                   .IsRequired();

            builder.Property(q => q.EndDate)
                   .HasColumnType("datetime2")
                   .IsRequired();

            builder.Property(q => q.DurationMintues)
                   .IsRequired();

            builder.Property(q => q.PassScore)
                   .HasPrecision(5, 2)
                   .HasDefaultValue(60.00m)
                   .IsRequired();

            builder.Property(q => q.MaxAttempts)
                   .IsRequired(false);

            builder.Property(q => q.Status)
                .HasConversion(
                    (QuizStatus status) => status.ToString(),
                    (string statusString) => Enum.Parse<QuizStatus>(statusString)
                )
                .HasMaxLength(20)
                .HasDefaultValue(QuizStatus.draft)
                .IsRequired();

            builder.Property(q => q.PublishedAt)
                   .HasColumnType("datetime2")
                   .IsRequired(false);

            builder.Property(q => q.IsDeleted)
                   .HasDefaultValue(false)
                   .IsRequired();

            builder.Property(q => q.DeletedAt)
                   .HasColumnType("datetime2")
                   .IsRequired(false);

            // Relationship: Diploma (1) to Quizzes (Many)
            builder.HasOne(q => q.Diploma)
                   .WithMany(d => d.Quizzes)
                   .HasForeignKey(q => q.DiplomaId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Relationship: Quiz (1) to QuizQuestions (Many)
            builder.HasMany(q => q.QuizQuestions)
                   .WithOne()
                   .HasForeignKey(qq => qq.QuizId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Relationship: Quiz (1) to QuizAttempts (Many)
            builder.HasMany(q => q.QuizAttempts)
                   .WithOne()
                   .HasForeignKey(qa => qa.QuizId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
