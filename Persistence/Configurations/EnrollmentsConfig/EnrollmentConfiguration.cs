using exam_system.Domain.Entities.Enrollments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.EnrollmentsConfig
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.ToTable("Enrollments");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .UseIdentityColumn();

            builder.Property(e => e.StudentId)
                   .IsRequired();

            builder.Property(e => e.DiplomaId)
                   .IsRequired();

            builder.Property(e => e.EnrolledAt)
                   .HasColumnType("datetime2")
                   .IsRequired();

            builder.Property(e => e.IsDeleted)
                   .HasDefaultValue(false)
                   .IsRequired();

            builder.Property(e => e.DeletedAt)
                   .HasColumnType("datetime2")
                   .IsRequired(false);
            //so the student can only enroll in a specific diploma once, we will create a unique index on the combination of StudentId and DiplomaId  

            builder.HasIndex(e => new { e.StudentId, e.DiplomaId })
                   .IsUnique();

            // Relationship: ApplicationUser (1) to Enrollments (Many)
            builder.HasOne(e => e.Student)
                   .WithMany(u => u.Enrollments)
                   .HasForeignKey(e => e.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Relationship: Diploma (1) to Enrollments (Many)
            builder.HasOne(e => e.Diploma)
                   .WithMany(d => d.Enrollments)
                   .HasForeignKey(e => e.DiplomaId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
