namespace Lab11_Roshambo;

internal class RandomPlayer : Player
{
    private Random random;
    public RandomPlayer()
    {
        Name = "Gambler";
        random = new Random();
    }
    public override Roshambo GenerateRoshambo()
    {
        return (Roshambo)random.Next(3);
    }
}