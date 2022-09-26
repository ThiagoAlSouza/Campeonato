using Campeonato.Domain.Commands;
using Campeonato.Domain.Entities.Team.Repository;
using Campeonato.Domain.Shared.Command;
using Campeonato.Domain.Shared.Handler.Interfaces;

namespace Campeonato.Domain.Handlers;

public class TeamHandler : IHandler<CreateTeamCommand>
{
    #region Privates

    private readonly IRepositoryTeam _repositoryTeam;

    #endregion

    #region Constructors

    public TeamHandler(IRepositoryTeam repositoryTeam)
    {
        _repositoryTeam = repositoryTeam;
    }

    #endregion

    #region Methods

    public CommandResult Handle(CreateTeamCommand command)
    {
        return new CommandResult();
    }

    #endregion
}