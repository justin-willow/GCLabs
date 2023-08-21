namespace Lab11_Roshambo;

public class Validator
{
    public static string GetValidName(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string userInput = Console.ReadLine().Trim();

            if (!string.IsNullOrEmpty(userInput) && userInput.All(char.IsLetter))
            {
                Console.WriteLine($"Hello {userInput}!");
                return userInput;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid name containing only alphabetic characters.");
            }
        }
    }
    public static Roshambo GetValidRoshambo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            Enum.TryParse(Console.ReadLine(), true, out Roshambo choiceRoshambo);

            if (choiceRoshambo == Roshambo.ROCK)
            {
                return Roshambo.ROCK;
            }
            else if (choiceRoshambo == Roshambo.PAPER)
            {
                return Roshambo.PAPER;
            }
            else if (choiceRoshambo == Roshambo.SCISSORS)
            {
                return Roshambo.SCISSORS;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter rock, paper, scissors, or their associated number.");
            }
        }
    }
    public static bool GetValidBoolInput(string prompt, string option1, string option2)
    {
        while (true)
        {
            Console.Write(prompt);
            string userInput = Console.ReadLine().ToLower();

            if (userInput == option1)
            {
                return true;
            }
            else if (userInput == option2)
            {
                return false;
            }
            else
            {
                Console.WriteLine($"Invalid input. Please enter '{option1}' or '{option2}'.");
            }
        }
    }
}