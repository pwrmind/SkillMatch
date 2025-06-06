using Microsoft.EntityFrameworkCore;

namespace WorkerService;

public class EmailNotificationContext : DbContext
{
    public DbSet<EmailNotificationTask> EmailNotificationTasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer("ConnectionString");
    }
}
