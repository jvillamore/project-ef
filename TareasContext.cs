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
        // Seeders.
        List<Category> categoryInit = new List<Category>{
            new Category{
                CategoryId = Guid.Parse("2103ffd7-67e4-48b2-b7c6-f5fcaf14c65c"),
                Description = "Descripcion 001",
                Name= "Category 001",
                CreationAt= DateTime.UtcNow,
                UpdateAt= DateTime.UtcNow,
            },
            new Category{
                CategoryId = Guid.Parse("2103ffd7-67e4-48b2-b7c6-f5fcaf14c601"),
                Description = "Descripcion 002",
                Name= "Category 001",
                CreationAt= DateTime.UtcNow,
                UpdateAt= DateTime.UtcNow,
            },
        };
        modelBuilder.Entity<Category>(category =>
        {
            // Table Category.
            category.ToTable("Category");
            category.HasKey(p => p.CategoryId);
            category.Property(p => p.Name).IsRequired().HasMaxLength(255).HasComment("Categories' name");
            category.Property(p => p.Description).HasComment("Categories' description");
            category.Property(p => p.CreationAt);
            category.Property(p => p.UpdateAt);
            // Inserta el seeder
            category.HasData(categoryInit);
        });
        // Seeder Task
        List<Task> taskInit = new List<Task>{
            new Task
            {
                TaskId= Guid.Parse("0003ffd7-67e4-48b2-b7c6-f5fcaf14c601"),
                Description= "Tarea 001",
                Titulo= "Titulo 001",
                PrioridadTarea= Priority.High,
                CategoryId= Guid.Parse("2103ffd7-67e4-48b2-b7c6-f5fcaf14c65c"),
                CreationAt= DateTime.UtcNow,
                UpdateAt= DateTime.UtcNow,
            },
             new Task
            {
                TaskId= Guid.Parse("1003ffd7-67e4-48b2-b7c6-f5fcaf14c601"),
                Description= "Tarea 002",
                Titulo= "Titulo 002",
                PrioridadTarea= Priority.High,
                CategoryId= Guid.Parse("2103ffd7-67e4-48b2-b7c6-f5fcaf14c601"),
                CreationAt= DateTime.UtcNow,
                UpdateAt= DateTime.UtcNow,
            },
        };
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
            task.Property(p => p.UpdateAt);
            task.Ignore(p => p.Resume);
            // Initial data
            task.HasData(taskInit);

        });
    }

}
