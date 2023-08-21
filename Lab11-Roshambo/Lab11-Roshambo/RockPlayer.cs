namespace Lab11_Roshambo;

internal class RockPlayer : Player
{
    public RockPlayer()
    {
        Name = "Rockman";
    }
    public override Roshambo GenerateRoshambo()
    {
        return Roshambo.ROCK;
    }
}