using Campeonato.Domain.Dados.Data;
using Campeonato.Domain.Dados.Repositories.Interfaces;
using Campeonato.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Campeonato.Domain.Dados.Repositories;

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

    public async Task<IEnumerable<Team>> GetAllTeams()
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
            throw new Exception("Algum registro está nulo.");
        }
    }

    public async Task<Team> Save(Team team)
    {
        try
        {
            await _dataContext.AddAsync(team);
            await _dataContext.SaveChangesAsync();

            return team;
        }
        catch (DbUpdateException)
        {
            throw new Exception("Erro ao salvar no banco.");
        }
    }

    #endregion
}