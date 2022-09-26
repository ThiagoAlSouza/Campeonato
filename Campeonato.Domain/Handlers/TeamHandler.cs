using Campeonato.Domain.Commands;
using Campeonato.Domain.Entities.Team;
using Campeonato.Domain.Entities.Team.Repository;
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
            return new CommandResult("Os dados de entrada estão inválidos.", false, errors);

        var team = new TeamEntity(command.Name, command.Coach, command.NumberPlayer, command.UniformColor, command.Shield);

        _repositoryTeam.Save(team);

        return new CommandResult("Registro salvo com sucesso", true, team);
    }

    #endregion
}