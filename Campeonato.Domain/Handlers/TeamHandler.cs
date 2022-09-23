using Campeonato.Domain.Commands;
using Campeonato.Domain.Shared.Command;
using Campeonato.Domain.Shared.Handler.Interfaces;

namespace Campeonato.Domain.Handlers;

public class TeamHandler : IHandler<CreateTeamCommand>
{
    #region Privates

    

    #endregion

    public CommandResult Handle(CreateTeamCommand command)
    {
        throw new NotImplementedException();
    }
}