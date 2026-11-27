using exam_system.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.IdentityConfig
{
    public class RefreshTokenConfiguration: IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.ToTable("RefreshTokens");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                   .UseIdentityColumn();

            builder.Property(r => r.UserId)
                   .IsRequired();

            builder.Property(r => r.TokenHash)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(r => r.ExpiresAt)
                   .HasColumnType("datetime2")
                   .IsRequired();

            builder.Property(r => r.IsUsed)
                   .HasDefaultValue(false)
                   .IsRequired();

            builder.Property(r => r.IsRevoked)
                   .HasDefaultValue(false)
                   .IsRequired();

            builder.Property(r => r.DeletedAt)
                   .HasColumnType("datetime2")
                   .IsRequired(false);

            builder.Property(r => r.IsDeleted)
                   .HasDefaultValue(false)
                   .IsRequired();

            // Relationship: ApplicationUser (1) to RefreshTokens (Many)
            builder.HasOne(r => r.User)
                   .WithMany()
                   .HasForeignKey(r => r.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
