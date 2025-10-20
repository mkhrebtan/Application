using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal sealed class EventParticipantConfiguration : IEntityTypeConfiguration<EventParticipant>
{
    public void Configure(EntityTypeBuilder<EventParticipant> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.EventId);
        builder.HasIndex(x => x.UserId);
        builder.HasIndex(x => x.VisitorId);
        builder.HasIndex(x => x.VisitorEmail);

        builder.HasIndex(x => new { x.EventId, x.VisitorId, }).IsUnique();
        builder.HasIndex(x => new { x.EventId, x.UserId, }).IsUnique();

        builder.Property(x => x.VisitorFirstName)
            .HasMaxLength(User.FirstNameMaxLength);
        builder.Property(x => x.VisitorLastName)
            .HasMaxLength(User.LastNameMaxLength);
        builder.Property(x => x.VisitorEmail)
            .HasMaxLength(User.EmailMaxLength);

        builder.HasOne<User>(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Event>(x => x.Event)
            .WithMany()
            .HasForeignKey(x => x.EventId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}