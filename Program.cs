using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_ef;
using project_ef.Models;

var builder = WebApplication.CreateBuilder(args);
// Consiguración para añadir la base de datos en memoria.
// builder.Services.AddDbContext<TareasContext>(context => context.UseInMemoryDatabase("TasksMemoryDb"));
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("csTareas"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/dbMemoryConexion", ([FromServices] TareasContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok($"Database created: {dbContext.Database.IsInMemory()}");
});
app.MapGet("/api/tareas", ([FromServices] TareasContext dbContext) =>
{
    return Results.Ok(dbContext.Tasks.Include(s => s.Category).Where(s => s.PrioridadTarea == project_ef.Models.Priority.High).ToList());
});

app.MapPost("/api/tareas", async ([FromServices] TareasContext dbContext, [FromBody] project_ef.Models.Task task) =>
{
    task.TaskId = Guid.NewGuid();
    task.CreationAt = DateTime.Now;
    //await dbContext.AddAsync(task);
    await dbContext.Tasks.AddAsync(task);
    await dbContext.SaveChangesAsync();
    return Results.Ok();
});

app.MapPut("/api/tareas/{id}", async ([FromServices] TareasContext dbContext, [FromBody] project_ef.Models.Task task, [FromRoute] Guid id) =>
{
    var vTask = dbContext.Tasks.Find(id);
    if (vTask is not null)
    {
        vTask.CategoryId = task.CategoryId;
        vTask.UpdateAt = DateTime.UtcNow;
        vTask.Titulo = task.Titulo;
        vTask.Description = task.Description;
        vTask.PrioridadTarea = task.PrioridadTarea;
    }
    await dbContext.SaveChangesAsync();
    return Results.Ok();
});

app.MapDelete("/api/tareas/{id}", async ([FromServices] TareasContext dbContext, [FromRoute] Guid id) =>
{
    var vTask = dbContext.Tasks.Find(id);
    if (vTask is not null)
    {
        dbContext.Tasks.Remove(vTask);
        await dbContext.SaveChangesAsync();
    }
    return Results.Ok();
});

app.Run();
