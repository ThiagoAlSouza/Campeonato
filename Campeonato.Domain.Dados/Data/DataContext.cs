using Campeonato.Domain.Dados.Mappings;
using Campeonato.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Campeonato.Domain.Dados.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Time> Times { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TimeMap());
    }
}