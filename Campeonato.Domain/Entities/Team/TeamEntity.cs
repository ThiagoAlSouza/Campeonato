namespace Campeonato.Domain.Entities.Team;

public class TeamEntity
{
    #region Constructors

    public TeamEntity(string name, string coach, int numberPlayer, string uniformColor)
    {
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
}