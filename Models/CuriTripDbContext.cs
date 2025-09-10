using Microsoft.EntityFrameworkCore;
namespace CuriTrip.Models;

public class CuriTripDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Passeio> Passeio => Set<Passeio>();
    public DbSet<Point> Points => Set<Point>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Point>();

        model.Entity<User>();

        model.Entity<Passeio>()
            .HasOne(u => u.User)
            .WithMany(p => p.AllPasseios)
            .HasForeignKey(p => p.User)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Passeio>()
            .HasMany(p => p.AllPoints)
            .WithMany(p => p.AllMyPasseios);
            
    }
}