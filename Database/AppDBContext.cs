using Microsoft.EntityFrameworkCore;

namespace TaskManager.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    // Add DbSet properties here..
    public DbSet<TaskManager.Models.Task> Tasks { get; set; }
}
