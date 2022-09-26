using Campeonato.Domain.Dados.Data;
using Campeonato.Domain.Dados.Repositories.Team;
using Campeonato.Domain.Entities.Team.Repository;
using Campeonato.Domain.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder);

var app = builder.Build();

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

void ConfigureServices(WebApplicationBuilder builder)
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddDbContext<DataContext>(x => x.UseInMemoryDatabase("Campeonato"));
    builder.Services.AddTransient<IRepositoryTeam, RepositoryTeam>();
    builder.Services.AddTransient<TeamHandler>();
}