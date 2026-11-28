using exam_system.Domain.Entities.Attempts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.AttemptConfiguration
{
    public class AttemptQuestionOptionsConfiguration
        : IEntityTypeConfiguration<AttemptQuestionOptions>
    {
        public void Configure(EntityTypeBuilder<AttemptQuestionOptions> builder)
        {
            builder.ToTable("AttemptQuestionOptions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.OptionText)
                .IsRequired();

            builder.Property(x => x.OptionOrder)
                .IsRequired();

            builder.Property(x => x.IsCorrect)
                .IsRequired();

            // AttemptQuestion Relationship
            builder.HasOne(x => x.AttemptQuestion)
                .WithMany(x => x.Options)
                .HasForeignKey(x => x.AttemptQuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            // Original Option Relationship
            builder.HasOne(x => x.OriginalOption)
                .WithMany()
                .HasForeignKey(x => x.OriginalOptionId)
                .OnDelete(DeleteBehavior.Restrict);

            // AttemptAnswer Relationship
            builder.HasMany(x => x.Answers)
                .WithOne(x => x.SelectedOption)
                .HasForeignKey(x => x.SelectedOptionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Indexes
            builder.HasIndex(x => new
            {
                x.AttemptQuestionId,
                x.OptionOrder
            }).IsUnique();

            builder.HasIndex(x => x.OriginalOptionId);
        }
    }
}
