using System.Text;

bool shouldContinue = true;

do
{
    Console.WriteLine("Hello, World!");

    Console.Write("Would you like to continue? (Y/N): ");
    string userInput = Console.ReadLine();
    if (string.Equals(userInput, "y", StringComparison.OrdinalIgnoreCase))
    {
        shouldContinue = true;
    }
    else if (string.Equals(userInput, "n", StringComparison.OrdinalIgnoreCase))
    {
        shouldContinue = false;
    }
    else
    {
        Console.WriteLine("Invalid input. Please Answer with either 'Y' or 'N'.");

        while (true)
        {
            Console.Write("Would you like to continue? (Y/N): ");
            userInput = Console.ReadLine();
            if (string.Equals(userInput, "y", StringComparison.OrdinalIgnoreCase))
            {
                shouldContinue = true;
                break;
            }
            else if (string.Equals(userInput, "n", StringComparison.OrdinalIgnoreCase))
            {
                shouldContinue = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please answer with either 'Y' or 'N'.");
            }
        }
    }
    if (!shouldContinue)
    {
        Console.WriteLine("Goodbye!");
    }
} while (shouldContinue);



bool isRunning = true;

while (isRunning)
{
    Console.Write("Enter a number: ");
    string userAnswer = Console.ReadLine();

    if (int.TryParse(userAnswer, out int userNumber))
    {
        StringBuilder countDown = new();

        for (int i = userNumber; i >= 0; i--)
        {
            countDown.Append($"{i} ");
        }

        if (countDown.Length > 0)
        {
            countDown.Length--;
        }

        Console.WriteLine(countDown.ToString());

        StringBuilder countUp = new();

        for (int i = 0; i <= userNumber; i++)
        {
            countUp.Append($"{i} ");
        }

        if (countUp.Length > 0)
        {
            countUp.Length--;
        }

        Console.WriteLine(countUp.ToString());
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer number.");
        continue;
    }

    Console.Write("Would you like to continue? (Y/N): ");
    string userInput = Console.ReadLine();
    if (string.Equals(userInput, "y", StringComparison.OrdinalIgnoreCase))
    {
        isRunning = true;
    }
    else if (string.Equals(userInput, "n", StringComparison.OrdinalIgnoreCase))
    {
        isRunning = false;
    }
    else
    {
        Console.WriteLine("Invalid input. Please Answer with either Y or N.");

        while (true)
        {
            Console.Write("Would you like to continue? (Y/N): ");
            userInput = Console.ReadLine();
            if (string.Equals(userInput, "y", StringComparison.OrdinalIgnoreCase))
            {
                isRunning = true;
                break;
            }
            else if (string.Equals(userInput, "n", StringComparison.OrdinalIgnoreCase))
            {
                isRunning = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please answer with either 'Y' or 'N'.");
            }
        }
    }
    if (!isRunning)
    {
        Console.WriteLine("Goodbye!");
    }
}



Console.Write("Enter the key code: ");
string keyCode = Console.ReadLine();
bool isDoorUnlocked = string.Equals(keyCode, "13579");

while (!isDoorUnlocked)
{
    Console.Write($"{keyCode} is incorrect. Please enter the key code: ");
    keyCode = Console.ReadLine();
    isDoorUnlocked = string.Equals(keyCode, "13579");
}

Console.WriteLine("Welcome!");



Console.WriteLine("You will now be limited to 5 attempts.");
isDoorUnlocked = false;

Console.Write("Enter the key code: ");
keyCode = Console.ReadLine();
isDoorUnlocked = string.Equals(keyCode, "13579");
int attemptsCount = 4;

while (!isDoorUnlocked && attemptsCount > 0)
{
    Console.Write($"{keyCode} is incorrect, {attemptsCount} {(attemptsCount == 1 ? "attempt" : "attempts")} remaining. Please enter the key code: ");
    keyCode = Console.ReadLine();
    isDoorUnlocked = string.Equals(keyCode, "13579");
    attemptsCount--;
}

if (isDoorUnlocked)
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Too many incorrect attempts. Access denied.");
}



Console.WriteLine("And again!");
isDoorUnlocked = false;

isDoorUnlocked = CheckKeyCode();

if (isDoorUnlocked)
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Too many incorrect attempts. Access Denied.");
}

static bool CheckKeyCode()
{
    int attemptsCount = 5;

    do
    {
        Console.Write("Enter the key code: ");
        string keyCode = Console.ReadLine();



        if (string.Equals(keyCode, "13579"))
        {
            return true;
        }

        attemptsCount--;
        Console.WriteLine($"{keyCode} is incorrect, {attemptsCount} {(attemptsCount == 1 ? "attempt" : "attempts")} remaining.");
    }
    while (attemptsCount > 0);

    return false;
}