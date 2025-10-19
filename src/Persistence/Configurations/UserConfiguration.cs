using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(User.EmailMaxLength);
        builder.Property(x => x.FirstName).IsRequired().HasMaxLength(User.FirstNameMaxLength);
        builder.Property(x => x.LastName).IsRequired().HasMaxLength(User.LastNameMaxLength);
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.PasswordHash).IsRequired().HasMaxLength(User.PasswordHashMaxLength);
        builder.HasMany<Event>()
            .WithOne()
            .HasForeignKey(x => x.OrganizerId);
    }
}