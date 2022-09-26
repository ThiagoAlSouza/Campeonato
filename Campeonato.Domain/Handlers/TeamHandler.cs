using Campeonato.Domain.Commands;
using Campeonato.Domain.Entities.Team;
using Campeonato.Domain.Entities.Team.Repository;
using Campeonato.Domain.Resource.Messages;
using Campeonato.Domain.Shared.Command;
using Campeonato.Domain.Shared.Handler.Interfaces;

namespace Campeonato.Domain.Handlers;

public class TeamHandler : IHandler<CreateTeamCommand>
{
    #region Privates

    private readonly IRepositoryTeam _repositoryTeam;
    private List<string> errors = new();

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
        if (!command.Validate(out errors))
            return new CommandResult(false, Messages.AlgumRegistroNulo, errors);

        var team = new TeamEntity(command.Name, command.Coach, command.NumberPlayer, command.UniformColor, new byte[23]);

        _repositoryTeam.Save(team);

        return new CommandResult(true, Messages.RegistroSalvoSucesso, team);
    }

    #endregion
}