using Campeonato.Domain.Shared.Command;
using Campeonato.Domain.Shared.Command.Interfaces;

namespace Campeonato.Domain.Shared.Handler.Interfaces;

public interface IHandler<T> where T : ICommand
{
    #region Assignatures

    CommandResult Handle(T command);

    #endregion
}