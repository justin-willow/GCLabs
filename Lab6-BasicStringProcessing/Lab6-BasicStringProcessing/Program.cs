bool shouldContinue = true;

while (shouldContinue)
{
    Console.Write("Enter a sentence: ");
    string[] userSentence = Console.ReadLine().Split(" ");

    foreach (string word in userSentence)
    {
        Console.WriteLine(word);
    }

    shouldContinue = ContinueChecker();
}

bool shouldContinue2 = true;
List<string> listText = new List<string>();

while (shouldContinue2)
{
    Console.Write("Enter some text: ");
    listText.Add(Console.ReadLine());

    string joinedText = string.Join(" ", listText);
    Console.WriteLine($"You have entered: {joinedText}");

    shouldContinue2 = ContinueChecker();
}
static bool ContinueChecker()
{
    Console.Write("Would you like to continue? (Y/N): ");
    string conInput;

    while (true)
    {
        conInput = Console.ReadLine().ToLower();

        if (conInput == "y")
        {
            return true;
        }
        else if (conInput == "n")
        {
            Console.WriteLine("Goodbye!");
            return false;
        }

        Console.Write("Invalid input. Please answer with either 'Y' or 'N': ");
    }
}