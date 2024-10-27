using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("doceDatabase"));

builder.Services.AddEndpointsApiExplorer()
builder.Services.AddSwaggerGen(c =>
{ 
    c.SwaggerDoc("v1", new OpenApiInfo
{
    Title = "Doces API",
    Description = "Fazendo doces com amor"
    Version = "v1"
});
});

var app = builder.Build();
if (app.Enviroment.isDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpont("/swagger/v1/swagger.jason", "Doces API V1");
    }); 
}

app.MapGet("/doces", async (AppDbContext db) => await db.Doces.ToListAsync());

app.Run();
