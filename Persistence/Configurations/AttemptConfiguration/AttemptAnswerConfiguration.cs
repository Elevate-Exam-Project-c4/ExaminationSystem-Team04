using exam_system.Domain.Entities.Attempts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.AttemptConfiguration
{
    public class AttemptAnswerConfiguration
        : IEntityTypeConfiguration<AttemptAnswer>
    {
        public void Configure(EntityTypeBuilder<AttemptAnswer> builder)
        {
            builder.ToTable("AttemptAnswers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.AnsweredAt)
                .IsRequired();

            builder.Property(x => x.IsCorrect)
                .IsRequired(false);

            builder.Property(x => x.DeletedAt)
                .IsRequired(false);

            builder.Property(x => x.IsDeleted)
                .IsRequired();

            // QuizAttempt Relationship
            builder.HasOne(x => x.Attempt)
                .WithMany()
                .HasForeignKey(x => x.AttemptId)
                .OnDelete(DeleteBehavior.Restrict);

            // AttemptQuestion Relationship (One-to-One)
            builder.HasOne(x => x.AttemptQuestion)
                .WithOne(x => x.Answer)
                .HasForeignKey<AttemptAnswer>(x => x.AttemptQuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            // Selected Option Relationship
            builder.HasOne(x => x.SelectedOption)
                .WithMany(x => x.Answers)
                .HasForeignKey(x => x.SelectedOptionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Indexes
            builder.HasIndex(x => x.AttemptId);

            builder.HasIndex(x => x.AttemptQuestionId)
                .IsUnique();

            builder.HasIndex(x => x.SelectedOptionId);
        }
    }
