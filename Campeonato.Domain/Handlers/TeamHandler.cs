using Campeonato.Domain.Commands.Team;
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
    private byte[] shield;

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
        try
        {
            if (!command.Validate(out errors))
                return new CommandResult(false, Messages.ErroSalvarBanco, errors);

            var team = new TeamEntity(command.Name, command.Coach, command.NumberPlayer, command.UniformColor);

            _repositoryTeam.Save(team);

            return new CommandResult(true, Messages.RegistroSalvoSucesso, team);
        }
        catch (Exception e)
        {
            return new CommandResult(true, Messages.RegistroSalvoSucesso, e.Message);
        }
        
    }

    #endregion
}