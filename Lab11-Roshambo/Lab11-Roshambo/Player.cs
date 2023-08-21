namespace Lab11_Roshambo;

internal abstract class Player
{
    public string Name { get; protected set; }
    public Roshambo Value { get; protected set; }

    public abstract Roshambo GenerateRoshambo();
}