using Microsoft.EntityFrameworkCore;

const string CorsAllowLocalhost = "CorsAllowLocalhost";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = "server=localhost;user=root;password=fireball1!;database=optn";

builder.Services.AddDbContext<webapi.OptnDbContext>(opt =>
{
    opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors();
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: CorsAllowLocalhost,
    policy =>
    {
        policy.WithOrigins("http://localhost:3333");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(CorsAllowLocalhost);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
