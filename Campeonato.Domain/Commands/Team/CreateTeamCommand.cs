using Campeonato.Domain.Resource.Messages;
using Campeonato.Domain.Shared.Command.Interfaces;

namespace Campeonato.Domain.Commands.Team;

public class CreateTeamCommand : ICommand
{
    #region Constructors

    public CreateTeamCommand(int id, string name, string coach, int numberPlayer, string uniformColor)
    {
        Id = id;
        Name = name;
        Coach = coach;
        NumberPlayer = numberPlayer;
        UniformColor = uniformColor;
    }

    #endregion

    #region Properties

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Coach { get; private set; }
    public int NumberPlayer { get; private set; }
    public string UniformColor { get; private set; }

    #endregion

    #region Methods

    public bool Validate(out List<string> validationsErrors)
    {
        validationsErrors = new List<string>();

        if (Name.Length <= 2)
            validationsErrors.Add(Messages.NomeTimePequeno);

        if (NumberPlayer > 30)
            validationsErrors.Add(Messages.UltrapassouLimiteJogadores);

        return validationsErrors.Count <= 0;
    }

    #endregion
}