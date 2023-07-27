string[] studentNames = new string[]
{
            "Alice",
            "Bob",
            "Charlie",
            "Diana",
            "Eva"
};

string[] favoriteFoods = new string[]
{
            "Pizza",
            "Burger",
            "Sushi",
            "Pasta",
            "Ice Cream"
};

string[] hometowns = new string[]
{
            "New York",
            "Los Angeles",
            "Seattle",
            "Detroit",
            "Dallas"
};

bool shouldContinue = true;
Console.WriteLine("Welcome!");

while (shouldContinue)
{
    Console.Write($"Which student would you like to learn more about? Enter a student number (1-{studentNames.Length}), their name, or \"list\": ");
    string userInput = Console.ReadLine().ToLower();

    int studentIndex = -1;
    int studentInput;

    if (int.TryParse(userInput, out studentInput) && studentInput > 0 && studentInput <= studentNames.Length)
    {
        studentIndex = studentInput - 1;
    }
    else if (string.Equals(userInput, "list", StringComparison.OrdinalIgnoreCase))
    {
        DisplayStudentList(studentNames);
        continue;
    }
    else
    {
        studentIndex = FindStudentIndexByName(userInput, studentNames);
    }

    if (studentIndex == -1)
    {
        Console.WriteLine("Invalid input. Please enter a valid student number, student name, or \"list\".");
        continue;
    }

    Console.Write($"Student {studentIndex + 1}: {studentNames[studentIndex]}. What would you like to know? Enter \"hometown\" or \"favorite food\": ");
    string category = ValidateCategory();

    if (string.Equals(category, "hometown", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"{studentNames[studentIndex]} is from {hometowns[studentIndex]}");
    }
    else if (string.Equals(category, "favorite food", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"{studentNames[studentIndex]}'s favorite food is {favoriteFoods[studentIndex].ToLower()}.");
    }

    shouldContinue = ContinueChecker();
}


static void DisplayStudentList(string[] studentNames)
{
    Console.WriteLine("List of all students:");
    for (int i = 0; i < studentNames.Length; i++)
    {
        Console.WriteLine($"Student {i + 1}: {studentNames[i]}");
    }
}
static int FindStudentIndexByName(string userInput, string[] studentNames)
{
    for (int i = 0; i < studentNames.Length; i++)
    {
        if (string.Equals(userInput, studentNames[i], StringComparison.OrdinalIgnoreCase))
        {
            return i;
        }
    }
    return -1;
}
static string ValidateCategory()
{
    string userInput;

    while (true)
    {
        userInput = Console.ReadLine().ToLower();

        if (userInput.Contains("hometown") || userInput.Contains("home") || userInput.Contains("town"))
        {
            return "hometown";
        }
        else if (userInput.Contains("favorite food") || userInput.Contains("favorite") || userInput.Contains("food"))
        {
            return "favorite food";
        }

        Console.Write("That category does not exist. Please try again. Enter a valid category: ");
    }
}
static bool ContinueChecker()
{
    Console.Write("Would you like to learn about another student? (Y/N): ");
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
            Console.WriteLine("Thank you! Goodbye!");
            return false;
        }

        Console.Write("Invalid input. Please answer with either 'Y' or 'N': ");
    }
}