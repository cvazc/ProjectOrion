using ProjectOrion.API.Services;
using ProjectOrion.API.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITaskService, TaskService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("api/tasks", (ITaskService service) =>
{
    var tasks = service.GetTasks();

    return Results.Ok(tasks);
});

app.Run();

