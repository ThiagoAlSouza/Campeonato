namespace Campeonato.Domain.Shared.Command.Interfaces;

public interface ICommand
{
    #region Assignatures

    bool Validate(out List<string> validationsErrors);

    #endregion
}