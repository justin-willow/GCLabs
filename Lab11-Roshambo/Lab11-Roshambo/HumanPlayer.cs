namespace Lab11_Roshambo;

internal class HumanPlayer : Player
{
    public HumanPlayer(string name)
    {
        Name = name;
    }

    public override Roshambo GenerateRoshambo()
    {
        return Validator.GetValidRoshambo("1. Rock, 2. paper, or 3. scissors? Enter either the choice or the associated number (1/2/3): ");
    }
}