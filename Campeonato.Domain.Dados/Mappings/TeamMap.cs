using Campeonato.Domain.Entities.Team;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campeonato.Domain.Dados.Mappings;

public class TeamMap : IEntityTypeConfiguration<TeamEntity>
{
    public void Configure(EntityTypeBuilder<TeamEntity> builder)
    {
        builder.ToTable("TIMES");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(x => x.Name)
            .HasColumnName("NAME")
            .HasColumnType("varchar(20)");

        builder.Property(x => x.Coach)
            .HasColumnName("COACH")
            .HasColumnType("varchar(30)");

        builder.Property(x => x.NumberPlayer)
            .HasColumnName("NUMBER_PLAYER")
            .HasColumnType("number(2)");

        builder.Property(x => x.UniformColor)
            .HasColumnName("UNIFORM_COLOR")
            .HasColumnType("varchar(30)");
    }
}