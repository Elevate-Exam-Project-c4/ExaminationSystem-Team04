using exam_system.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace exam_system.Persistence.Configurations.IdentityConfig
{
    public class PasswordResetTokenConfiguration : IEntityTypeConfiguration<PasswordResetToken>
    {
        public void Configure(EntityTypeBuilder<PasswordResetToken> builder)
        {
            builder.ToTable("PasswordResetTokens");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .UseIdentityColumn();

            
            builder.Property(p => p.UserId)
                   .IsRequired();

            builder.Property(p => p.TokenHash)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(p => p.ExpiresAt)
                   .HasColumnType("datetime2")
                   .IsRequired();

            builder.Property(p => p.IsUsed)
                   .HasDefaultValue(false)
                   .IsRequired();

            builder.Property(p => p.DeletedAt)
                   .HasColumnType("datetime2")
                   .IsRequired(false);

            builder.Property(p => p.IsDeleted)
                   .HasDefaultValue(false)
                   .IsRequired();

            // Relationship: ApplicationUser (1) to PasswordResetTokens (Many)
            builder.HasOne(p => p.User)
                   .WithMany(u => u.PasswordResetTokens)
                   .HasForeignKey(p => p.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
