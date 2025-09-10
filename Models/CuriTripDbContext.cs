using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
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
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Passeio>()
            .HasMany(p => p.AllPoints)
            .WithMany(p => p.AllMyPasseios);

    }
}

public class RPlaceDbContextFactory : IDesignTimeDbContextFactory<CuriTripDbContext>
{
    public CuriTripDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<CuriTripDbContext>();
        var sqlConn = Environment.GetEnvironmentVariable("SQL_CONNECTION");
        options.UseSqlServer(sqlConn);
        return new CuriTripDbContext(options.Options);
    }
}