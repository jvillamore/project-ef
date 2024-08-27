using Microsoft.EntityFrameworkCore;
using project_ef.Models;

namespace project_ef;

public class TareasContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Models.Task> Tasks { get; set; }

    public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

}
