namespace Lab10_Circle;

public static class Validator
{
    public static double GetValidDoubleInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double inputValue) && inputValue > 0)
            {
                return inputValue;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
            }
        }
    }
    public static bool GetValidYesNoInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
            {
                return true;
            }
            else if (userInput == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no.");
            }
        }
    }
}