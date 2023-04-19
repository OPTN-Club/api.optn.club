using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi;

public class OptnDbContext : DbContext
{
    public OptnDbContext(DbContextOptions<OptnDbContext> options) : base(options)
    {
    }

    public DbSet<Tune> Tunes { get; set; }
    public DbSet<Upgrades> Upgrades { get; set; }
    public DbSet<Settings> Settings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tune>().ToTable("tunes");
        modelBuilder.Entity<Tune>()
            .HasOne(p => p.Upgrades)
            .WithOne()
            .HasForeignKey<Upgrades>(p => p.Id);

        modelBuilder.Entity<Tune>()
            .HasOne(p => p.Settings)
            .WithOne()
            .HasForeignKey<Settings>(p => p.Id);

        modelBuilder.Entity<Upgrades>().ToTable("upgrades");
        modelBuilder.Entity<Upgrades>().OwnsOne(p => p.Width);
        modelBuilder.Entity<Upgrades>().OwnsOne(p => p.RimSize);
        modelBuilder.Entity<Upgrades>().OwnsOne(p => p.RimStyle);

        modelBuilder.Entity<Settings>().ToTable("settings");
        modelBuilder.Entity<Settings>().OwnsOne(p => p.TirePressure);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.Gears);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.Camber);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.Toe);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.ARB);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.Springs);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.RideHeight);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.Damping);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.Bump);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.Aero);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.Brakes);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.Differential).OwnsOne(p => p.Front);
        modelBuilder.Entity<Settings>().OwnsOne(p => p.Differential).OwnsOne(p => p.Rear);
    }
}
