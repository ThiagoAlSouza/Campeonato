using Campeonato.Domain.Dados.Repositories.Team;
using Campeonato.Domain.Entities.Team.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AddServices(builder);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

void AddServices(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IRepositoryTeam, RepositoryTeam>();
}