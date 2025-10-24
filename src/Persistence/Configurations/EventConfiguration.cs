using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal sealed class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(Event.TitleMaxLength);
        builder.Property(x => x.Description).HasMaxLength(Event.DescriptionMaxLength);
        builder.Property(x => x.Date).IsRequired();
        builder.Property(x => x.Location).IsRequired().HasMaxLength(Event.LocationMaxLength);
        builder.Property(x => x.Capacity);
        builder.Property(x => x.IsPublic).IsRequired();
        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(x => x.OrganizerId)
            .IsRequired();
        builder.HasMany<EventTag>()
            .WithOne(x => x.Event)
            .HasForeignKey(x => x.EventId);
        builder.HasMany<EventParticipant>()
            .WithOne(x => x.Event)
            .HasForeignKey(x => x.EventId);
    }
}