bool shouldContinue = true;

while (shouldContinue)
{
    while (true)
    {
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int limit) && limit > 0)
        {
            int total = CalculateSum(limit);
            Console.WriteLine(total);
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            continue;
        }
    }

    shouldContinue = ContinueChecker();
}
static int CalculateSum(int limit)
{
    int total = 0;

    for (int i = 1; i <= limit; i++)
    {
        total += i;
    }

    return total;
}

static bool ContinueChecker()
{
    while (true)
    {
        Console.Write("Would you like to continue? (Y/N): ");
        string conInput = Console.ReadLine();

        if (string.Equals(conInput, "y", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        else if (string.Equals(conInput, "n", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Goodbye!");
            return false;
        }
        else
        {
            Console.WriteLine("Invalid input. Please answer with either 'Y' or 'N'.");
        }
    }
}