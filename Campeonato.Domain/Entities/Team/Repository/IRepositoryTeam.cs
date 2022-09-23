using Campeonato.Domain.Entities.Team;
namespace Campeonato.Domain.Entities.Team.Repository;

public interface IRepositoryTeam
{
    #region Assignatures

    Task<IEnumerable<TeamEntity>> GetAllTeams();
    Task<TeamEntity> Save(TeamEntity team);

    #endregion
}