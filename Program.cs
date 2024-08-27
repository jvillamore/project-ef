using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_ef;

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

app.Run();
