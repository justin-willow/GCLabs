using Lab11_Roshambo;

Console.WriteLine("Welcome to Rock Paper Scissors!");

var humanPlayer = new HumanPlayer(Validator.GetValidName("Enter your name: "));

bool playAgain;

bool isRockman = Validator.GetValidBoolInput("Would you like to play against Rockman or Gambler? Choose either 'R' or 'G': ", "r", "g");
Player opponent = isRockman ? new RockPlayer() : new RandomPlayer();

int playerWins = 0;
int opponentWins = 0;

do
{

    Roshambo playerChoice = humanPlayer.GenerateRoshambo();
    Roshambo opponentChoiceValue = opponent.GenerateRoshambo();

    Console.WriteLine($"{humanPlayer.Name}: {playerChoice}");
    Console.WriteLine($"{opponent.Name}: {opponentChoiceValue}");

    if (playerChoice == opponentChoiceValue)
    {
        Console.WriteLine("Draw!");
    }
    else if ((playerChoice == Roshambo.ROCK && opponentChoiceValue == Roshambo.SCISSORS) ||
             (playerChoice == Roshambo.PAPER && opponentChoiceValue == Roshambo.ROCK) ||
             (playerChoice == Roshambo.SCISSORS && opponentChoiceValue == Roshambo.PAPER))
    {
        Console.WriteLine($"{humanPlayer.Name} wins!");
        playerWins++;
    }
    else
    {
        Console.WriteLine($"{opponent.Name} wins!");
        opponentWins++;
    }
    Console.WriteLine($"Total wins for {humanPlayer.Name}: {playerWins}");
    Console.WriteLine($"Total wins for {opponent.Name}: {opponentWins}");

    playAgain = Validator.GetValidBoolInput("Play again? (y/n): ", "y", "n");
} while (playAgain);