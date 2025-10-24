using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.SampleData;

namespace Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Event> Events { get; set; }

    public DbSet<EventParticipant> EventParticipants { get; set; }

    public DbSet<RefreshToken> RefreshTokens { get; set; }

    public DbSet<Tag> Tags { get; set; }

    public DbSet<EventTag> EventTags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        modelBuilder.Entity<Tag>().HasData(DatabaseSeeder.Tags);
        modelBuilder.Entity<User>().HasData(DatabaseSeeder.Users);
        var events = DatabaseSeeder.Events(DatabaseSeeder.Users);
        modelBuilder.Entity<Event>().HasData(events);
        modelBuilder.Entity<EventTag>()
            .HasData(DatabaseSeeder.EventTags(events, DatabaseSeeder.Tags));

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql();
        base.OnConfiguring(optionsBuilder);
    }
}