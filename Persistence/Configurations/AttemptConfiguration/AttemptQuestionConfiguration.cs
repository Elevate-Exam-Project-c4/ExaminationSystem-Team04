using exam_system.Domain.Entities.Attempts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.AttemptConfiguration
{
    public class AttemptQuestionConfiguration : IEntityTypeConfiguration<AttemptQuestion>
    {
        public void Configure(EntityTypeBuilder<AttemptQuestion> builder)
        {
            builder.ToTable("AttemptQuestions");

            builder.HasKey(x => x.Id);

            // Question snapshot
            builder.Property(x => x.QuestionText)
                .IsRequired();

            builder.Property(x => x.Explanation)
                .IsRequired(false);

            builder.Property(x => x.OrderIndex)
                .IsRequired();

            // QuizAttempt Relationship
            builder.HasOne(x => x.Attempt)
                .WithMany(x => x.Questions)
                .HasForeignKey(x => x.AttemptId)
                .OnDelete(DeleteBehavior.Cascade);

            // Original Question Relationship
            builder.HasOne(x => x.OriginalQuestion)
                .WithMany()
                .HasForeignKey(x => x.OriginalQuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            // AttemptQuestionOptions Relationship
            builder.HasMany(x => x.Options)
                .WithOne(x => x.AttemptQuestion)
                .HasForeignKey(x => x.AttemptQuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            // AttemptAnswer Relationship (One-to-One)
            builder.HasOne(x => x.Answer)
                .WithOne(x => x.AttemptQuestion)
                .HasForeignKey<AttemptAnswer>(x => x.AttemptQuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            // Indexes
            builder.HasIndex(x => new
            {
                x.AttemptId,
                x.OrderIndex
            }).IsUnique();

            builder.HasIndex(x => x.OriginalQuestionId);
        }
    }
}
