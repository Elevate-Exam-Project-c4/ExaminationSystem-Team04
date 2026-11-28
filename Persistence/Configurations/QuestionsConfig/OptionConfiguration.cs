using exam_system.Domain.Entities.Questions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class OptionConfiguration : IEntityTypeConfiguration<Option>
{
    public void Configure(EntityTypeBuilder<Option> builder)
    {
        builder.ToTable("Options");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Text)
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .IsRequired();

        builder.Property(x => x.DeletedAt)
            .IsRequired(false);

        // Option - QuestionOption (One-to-Many)
        builder.HasMany(x => x.QuestionOptions)
            .WithOne(x => x.Option)
            .HasForeignKey(x => x.OptionId)
            .OnDelete(DeleteBehavior.Restrict);

        // Option - AttemptQuestionOptions (One-to-Many)
        builder.HasMany(x => x.AttemptOption)
            .WithOne(x => x.OriginalOption)
            .HasForeignKey(x => x.OriginalOptionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.IsDeleted);
    }
}