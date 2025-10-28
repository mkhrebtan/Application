using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class EventTagConfiguration : IEntityTypeConfiguration<EventTag>
{
    public void Configure(EntityTypeBuilder<EventTag> builder)
    {
        builder.HasKey(x => new { x.EventId, x.TagId, });
        builder.HasOne<Event>(x => x.Event)
            .WithMany(e => e.EventTags)
            .HasForeignKey(et => et.EventId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne<Tag>(x => x.Tag)
            .WithMany()
            .HasForeignKey(et => et.TagId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}