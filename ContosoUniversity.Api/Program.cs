using ContosoUniversity.Application.Interfaces;
using ContosoUniversity.Persistence;
using ContosoUniversity.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContosoUniversityDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("LevelUpUniversityDatabase")));

builder.Services.AddScoped<ISubjectsRepository, SubjectsRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ContosoUniversityDbContext>();
    dbContext.Database.Migrate();
    ContosoUniversityDbContextIntializer.Seed(dbContext);
}

app.Run();
