using Microsoft.EntityFrameworkCore;
using project_ef.Models;
using Task = project_ef.Models.Task;

namespace project_ef;

public class TareasContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Models.Task> Tasks { get; set; }

    public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(category =>
        {
            // Table Category.
            category.ToTable("Category");
            category.HasKey(p => p.CategoryId);
            category.Property(p => p.Name).IsRequired().HasMaxLength(255).HasComment("Categories' name");
            category.Property(p => p.Description).HasComment("Categories' description");
        });
        // Table Tasks
        modelBuilder.Entity<Task>(task =>
        {
            // Table Category.
            task.ToTable("Task");
            task.HasKey(p => p.TaskId);
            // Creacion de la relacion 1:n
            task.HasOne(p => p.Category).WithMany(p => p.Tasks).HasForeignKey(p => p.CategoryId);
            task.Property(p => p.Titulo).IsRequired().HasMaxLength(255).HasComment("Task title");
            task.Property(p => p.Description).HasComment("task description");
            task.Property(p => p.PrioridadTarea);
            task.Property(p => p.CreationAt);
            task.Ignore(p => p.Resume);
        });
    }

}
