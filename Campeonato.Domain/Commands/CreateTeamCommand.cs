using Campeonato.Domain.Shared.Command.Interfaces;

namespace Campeonato.Domain.Commands;

internal class CreateTeamCommand : ICommand
{
    #region Constructors

    public CreateTeamCommand(int id, string name, string coach, int numberPlayer, string uniformColor, byte[] shield)
    {
        Id = id;
        Name = name;
        Coach = coach;
        NumberPlayer = numberPlayer;
        UniformColor = uniformColor;
        Shield = shield;
    }

    #endregion

    #region Properties

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Coach { get; private set; }
    public int NumberPlayer { get; private set; }
    public string UniformColor { get; private set; }
    public Byte[] Shield { get; private set; }

    #endregion

    #region Methods

    public bool Validate(out List<string> validationsErrors)
    {
        throw new NotImplementedException();
    }

    #endregion
}