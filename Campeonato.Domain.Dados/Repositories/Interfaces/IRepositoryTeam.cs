using Campeonato.Domain.Entities;

namespace Campeonato.Domain.Dados.Repositories.Interfaces;

public interface IRepositoryTeam
{
    #region Assignatures

    Task<IEnumerable<Team>> GetAllTeams();
    Task<Team> Save(Team team);

    #endregion
}