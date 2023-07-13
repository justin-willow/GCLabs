bool shouldContinue = true;

Console.WriteLine("What is your name?");
string userInput = Console.ReadLine();
string userName = string.IsNullOrWhiteSpace(userInput) ? "Unknown" : userInput;

while (shouldContinue)
{
    Console.WriteLine($"Hello, {userName}! Please enter a number between 1 and 100 (inclusive).");

    string input = Console.ReadLine();

    if (int.TryParse(input, out int userNumber) && userNumber >= 1 && userNumber <= 100)
    {
        if (userNumber % 2 != 0 && userNumber < 60)
        {
            Console.WriteLine($"{userName}, you entered {userNumber}, which is an odd number less than 60.");
        }
        else if (userNumber % 2 == 0 && userNumber <= 24)
        {
            Console.WriteLine($"{userName}, you entered {userNumber}, which is an even number less than 25.");
        }
        else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
        {
            Console.WriteLine($"{userName}, you entered {userNumber}, which is an even number between 26 and 60 (inclusive).");
        }
        else if (userNumber % 2 == 0 && userNumber > 60)
        {
            Console.WriteLine($"{userName}, you entered {userNumber}, which is an even number greater than 60.");
        }
        else if (userNumber % 2 != 0 && userNumber > 60)
        {
            Console.WriteLine($"{userName}, you entered {userNumber}, which is an odd number greater than 60.");
        }
    }
    else
    {
        Console.WriteLine("Whoops! That's an invalid input. Please enter a valid integer between 1 and 100.");
    }

    Console.WriteLine($"{userName}, would you like to continue? (Y/N)");
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    shouldContinue = string.Equals(keyInfo.KeyChar.ToString(), "y", StringComparison.OrdinalIgnoreCase);
    Console.ReadLine();
}