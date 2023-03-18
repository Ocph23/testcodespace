using Microsoft.EntityFrameworkCore;

namespace BlazorApp;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Student> Students { get; set; }
}