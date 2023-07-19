bool validInput = false;
int diceSides = 0;

Console.WriteLine("Welcome to the Grand Circus Casino!");

while (!validInput)
{
    try
    {
        Console.Write("How many sides should each die have?: ");
        int input = int.Parse(Console.ReadLine());

        if (input > 2)
        {
            diceSides = input;
            validInput = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer greater than 2.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Invalid input. The entered value is too large.");
    }
}

bool playAgain = true;
int rollCount = 1;

while (playAgain)
{
    Console.WriteLine();

    Console.WriteLine($"Roll {rollCount}:");
    int dice1 = GenerateRandomNumber(diceSides);
    int dice2 = GenerateRandomNumber(diceSides);
    int totalScore = dice1 + dice2;

    Console.WriteLine($"You rolled a {dice1} and a {dice2} ({totalScore} total)");

    string combination = GetCombination(diceSides, dice1, dice2);
    if (!string.IsNullOrEmpty(combination))
    {
        Console.WriteLine(combination);
    }
    string totalResult = GetTotal(diceSides, totalScore);
    if (!string.IsNullOrEmpty(totalResult))
    {
        Console.WriteLine(totalResult);
    }

    Console.WriteLine();

    Console.Write("Roll again? (Y/N): ");
    string userInput;

    do
    {
        userInput = Console.ReadLine();

        if (string.Equals(userInput, "y", StringComparison.OrdinalIgnoreCase))
        {
            rollCount++;
            playAgain = true;
            break;
        }
        else if (string.Equals(userInput, "n", StringComparison.OrdinalIgnoreCase))
        {
            playAgain = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please answer with either 'Y' or 'N'.");
        }

    } while (true);

    if (!playAgain)
    {
        Console.WriteLine("Thanks for playing!");
    }

}

static int GenerateRandomNumber(int diceSides)
{
    Random random = new();
    return random.Next(1, diceSides + 1);
}

static string GetCombination(int diceSides, int dice1, int dice2)
{
    switch (diceSides)
    {
        case 6:
            if (dice1 == 1 && dice2 == 1)
                return "Snake Eyes";
            else if (dice1 == 1 && dice2 == 2)
                return "Ace Deuce";
            else if (dice1 == 6 && dice2 == 6)
                return "Boxcars";
            break;
        case 8:
            if (dice1 == 1 && dice2 == 2)
                return "King's Ransom";
            else if (dice1 == 1 && dice2 == 3)
                return "Queen's Gambit";
            else if (dice1 == 8 && dice2 == 8)
                return "Valor";
            break;
        case 10:
            if (dice1 == 1 && dice2 == 10)
                return "Royal Feast";
            else if (dice1 == 10 && dice2 == 10)
                return "Excalibur";
            break;
        case 12:
            if (dice1 == 12 && dice2 == 12)
                return "Wizard";
            else if (dice1 == 1 && dice2 == 1)
                return "Fool's Prank";
            break;
    }

    return string.Empty;
}

static string GetTotal(int diceSides, int total)
{
    switch (diceSides)
    {
        case 6:
            if (total == 7 || total == 11)
                return "Win!";
            else if (total == 2 || total == 3 || total == 12)
                return "Craps!";
            break;
    }

    return string.Empty;
}