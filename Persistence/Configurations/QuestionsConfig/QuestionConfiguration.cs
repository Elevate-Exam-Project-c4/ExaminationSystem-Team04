using exam_system.Domain.Entities.Questions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.QuestionsConfig
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Text)
                .IsRequired();

            builder.Property(x => x.Explaination)
                .IsRequired(false);

            builder.Property(x => x.IsDeleted)
                .IsRequired();

            builder.Property(x => x.DeletedAt)
                .IsRequired(false);

            // Question - QuestionOption (One-to-Many)
            builder.HasMany(x => x.QuestionOptions)
                .WithOne(x => x.Question)
                .HasForeignKey(x => x.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Question - AttemptQuestion (One-to-Many)
            builder.HasMany(x => x.AttemptQuestions)
                .WithOne(x => x.OriginalQuestion)
                .HasForeignKey(x => x.OriginalQuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => x.IsDeleted);
        }
    }
}
