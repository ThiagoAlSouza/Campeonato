using Campeonato.Domain.Dados.Data;
using Campeonato.Domain.Entities.Team;
using Campeonato.Domain.Entities.Team.Repository;
using Campeonato.Domain.Resource.Messages;
using Microsoft.EntityFrameworkCore;

namespace Campeonato.Domain.Dados.Repositories.Team;

public class RepositoryTeam : IRepositoryTeam
{
    #region privates

    private readonly DataContext _dataContext;

    #endregion

    #region Constructos

    public RepositoryTeam(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    #endregion

    #region Methods

    public async Task<IEnumerable<TeamEntity>> GetAllTeams()
    {
        try
        {
            return await _dataContext
                .Times
                .AsNoTracking()
                .ToListAsync();
        }
        catch (ArgumentNullException)
        {
            throw new Exception(Messages.AlgumRegistroNulo);
        }
    }

    public async Task<TeamEntity> Save(TeamEntity team)
    {
        try
        {
            await _dataContext.AddAsync(team);
            await _dataContext.SaveChangesAsync();

            return team;
        }
        catch (DbUpdateException)
        {
            throw new Exception(Messages.ErroSalvarBanco);
        }
    }

    #endregion
}