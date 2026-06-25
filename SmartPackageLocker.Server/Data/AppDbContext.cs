using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

    public DbSet<Locker> Lockers => Set<Locker>();

    public DbSet<PackageItem> Packages => Set<PackageItem>();
}