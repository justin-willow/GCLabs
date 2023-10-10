using Microsoft.EntityFrameworkCore;

namespace AdoptionMVC.Models.Data;

public class AppDbContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

}