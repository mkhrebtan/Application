using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.HasMany<EventTag>()
            .WithOne(et => et.Tag)
            .HasForeignKey(et => et.TagId);
        builder.Property(x => x.NormalizedName).IsRequired().HasMaxLength(50);
        builder.HasIndex(x => x.NormalizedName).IsUnique();
    }
}