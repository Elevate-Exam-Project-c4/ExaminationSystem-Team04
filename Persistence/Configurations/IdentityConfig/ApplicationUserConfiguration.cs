using exam_system.Common.Enums;
using exam_system.Domain.Common.Enums;
using exam_system.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam_system.Persistence.Configurations.IdentityConfig
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("AspNetUsers");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("NEWID()");

            builder.Property(u => u.FullName)
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnType("nvarchar(320)")
                .HasMaxLength(320)
                .IsRequired();

            builder.Property(u => u.NormalizedEmail)
                .HasMaxLength(320);

            builder.HasIndex(u => u.NormalizedEmail)
                .IsUnique()
                .HasDatabaseName("EmailIndex");

            builder.Property(u => u.Role)
         .HasConversion(
             (UserRole role) => role.ToString(),
             (string roleString) => Enum.Parse<UserRole>(roleString)
         ).HasMaxLength(20)
            .HasDefaultValue(UserRole.Student)
            .IsRequired();


            builder.Property(u => u.AccountStatus)
                .HasConversion(
                    (AccountStatus status) => status.ToString(),
                    (string statusString) => Enum.Parse<AccountStatus>(statusString)
                ).HasMaxLength(20)
                .HasDefaultValue(AccountStatus.Pending)
                 .IsRequired();


            builder.Property(u => u.LastActivityAt)
                .HasColumnType("datetime2")
                .IsRequired(false);

            builder.Property(u => u.CreatedAt)
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(u => u.UpdatedAt)
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(u => u.DeletedAt)
                .HasColumnType("datetime2")
                .IsRequired(false);

            builder.Property(u => u.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(u => u.PasswordHash)
                .HasColumnType("nvarchar(500)")
                .IsRequired();

            builder.Property(u => u.EmailConfirmed)
                .HasColumnType("bit")
                .HasDefaultValue(false)
                .IsRequired();


            builder.Property(u => u.AccessFailedCount)
                .HasColumnName("FailedLoginAttempts")
                .HasColumnType("int")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(u => u.LockoutEnd)
                .HasColumnType("datetimeoffset")
                .IsRequired(false);

            builder.HasQueryFilter(u => !u.IsDeleted);

        }
    }
}
