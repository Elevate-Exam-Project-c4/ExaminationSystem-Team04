using exam_system.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.IdentityConfig
{
    public class OtpCodeConfiguration : IEntityTypeConfiguration<OtpCode>
    {
        public void Configure(EntityTypeBuilder<OtpCode> builder)
        {
            builder.ToTable("OtpCodes");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id)
                .UseIdentityColumn();

            builder.Property(o => o.Email)
                .HasMaxLength(320)
                .IsRequired();

            builder.Property(o => o.CodeHash)
                .IsRequired();

            builder.Property(o => o.ExpiresAt)
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(o => o.IsUsed)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(o => o.AttemptCount)
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(o => o.IsResend)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(o => o.CreatedAt)
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(o => o.UpdatedAt)
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(o => o.DeletedAt)
                .HasColumnType("datetime2")
                .IsRequired(false);

            builder.Property(o => o.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}

