using Microsoft.EntityFrameworkCore;
using motoApi.Context;
using motoApi.Repositories;
using motoApi.Services;
using static motoApi.Services.MotoService;

var builder = WebApplication.CreateBuilder(args);

// Configurar DbContext com SQLite
builder.Services.AddDbContext<MotoContext>(options =>
    options.UseSqlite("Data Source=motos.db"));

// Registrar serviços e repositórios
builder.Services.AddScoped<MotoRepository>();
builder.Services.AddScoped<MotoServices>();

// Configuração padrão do ASP.NET
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
