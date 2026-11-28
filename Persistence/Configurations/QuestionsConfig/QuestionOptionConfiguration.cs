using exam_system.Domain.Entities.Questions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.QuestionsConfig
{
    public class QuestionOptionConfiguration : IEntityTypeConfiguration<QuestionOption>
    {
        public void Configure(EntityTypeBuilder<QuestionOption> builder)
        {
            builder.ToTable("QuestionOptions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.IsCorrect)
                .IsRequired();

            builder.Property(x => x.OrderIndex)
                .IsRequired();

            builder.Property(x => x.IsDeleted)
                .IsRequired();

            builder.Property(x => x.DeletedAt)
                .IsRequired(false);

            // QuestionOption - Question (Many-to-One)
            builder.HasOne(x => x.Question)
                .WithMany(x => x.QuestionOptions)
                .HasForeignKey(x => x.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            // QuestionOption - Option (Many-to-One)
            builder.HasOne(x => x.Option)
                .WithMany(x => x.QuestionOptions)
                .HasForeignKey(x => x.OptionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Prevent duplicate active options in the same question
            builder.HasIndex(x => new
            {
                x.QuestionId,
                x.OptionId
            })
            .IsUnique()
            .HasFilter("[IsDeleted] = 0");

            // Prevent duplicate active order indexes in the same question
            builder.HasIndex(x => new
            {
                x.QuestionId,
                x.OrderIndex
            })
            .IsUnique()
            .HasFilter("[IsDeleted] = 0");

            // A question can have at most one active correct option
            builder.HasIndex(x => x.QuestionId)
                .IsUnique()
                .HasFilter("[IsCorrect] = 1 AND [IsDeleted] = 0");
        }
    }
}
