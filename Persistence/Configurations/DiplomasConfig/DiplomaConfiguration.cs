using exam_system.Domain.Entities.Diplomas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.DiplomasConfig
{
    public class DiplomaConfiguration : IEntityTypeConfiguration<Diploma>
    {
        public void Configure(EntityTypeBuilder<Diploma> builder)
        {
            builder.ToTable("Diplomas");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                   .HasDefaultValueSql("NEWID()")
                   .ValueGeneratedOnAdd();

            builder.Property(d => d.Title)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(d => d.Description)
                   .HasMaxLength(1000)
                   .IsRequired(false);

            builder.Property(d => d.IsDeleted)
                   .HasDefaultValue(false)
                   .IsRequired();

            builder.Property(d => d.DeletedAt)
                   .HasColumnType("datetime2")
                   .IsRequired(false);

            // Relationship: Diploma (1) to Enrollments (Many)
            builder.HasMany(d => d.Enrollments)
                   .WithOne()
                   .HasForeignKey(e => e.DiplomaId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Relationship: Diploma (1) to Quizzes (Many)
            builder.HasMany(d => d.Quizzes)
                   .WithOne()
                   .HasForeignKey(q => q.DiplomaId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
