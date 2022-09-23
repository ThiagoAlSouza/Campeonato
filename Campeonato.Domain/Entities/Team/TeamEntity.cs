namespace Campeonato.Domain.Entities.Team;

public class TeamEntity
{
    #region MyRegion

    public TeamEntity(int id, string name, string coach, int numberPlayer, string uniformColor, byte[] shield)
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
    public byte[] Shield { get; private set; }

    #endregion
}