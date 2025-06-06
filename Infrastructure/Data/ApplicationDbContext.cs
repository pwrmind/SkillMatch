using Microsoft.EntityFrameworkCore;
using Domain.Aggregates;

namespace Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Applicant> Applicants { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Skill> Skills { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Конфигурация сущностей
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
