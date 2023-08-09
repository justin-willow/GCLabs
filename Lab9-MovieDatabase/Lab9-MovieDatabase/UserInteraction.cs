using Spectre.Console;
namespace Lab9_MovieDatabase;
public class UserInteraction
{
    public static List<Categories> DisplayMenu(List<Movie> movies)
    {
        var categoryList = movies.Select(x => x.Category).Distinct().OrderBy(x => x).ToList();

        var table = new Table();
        table.Border = TableBorder.AsciiDoubleHead;
        table.AddColumn(new TableColumn("Category"));

        for (int i = 0; i < categoryList.Count; i++)
        {
            if (i % 2 == 0)
            {
                table.AddRow(new Markup($"[deepskyblue2]{i + 1}. [/][wheat1]{categoryList[i]}[/]"));
            }
            else
            {
                table.AddRow(new Markup($"[deepskyblue3]{i + 1}. [/][lightgoldenrod2]{categoryList[i]}[/]"));
            }
        }
        AnsiConsole.Write(table);

        return categoryList;
    }
    public static void DisplayMovies(List<Movie> movies)
    {
        bool validCategorySelected = false;

        while (!validCategorySelected)
        {
            string userInput = Console.ReadLine().Trim().ToUpper();
            Enum.TryParse(userInput, out Categories choiceCategory);

            if (Enum.IsDefined(typeof(Categories), choiceCategory))
            {
                var movieList = movies.Where(x => x.Category == choiceCategory).OrderBy(x => x.Title).ToList();

                DisplayMovieTable(movieList);

                validCategorySelected = true;
            }
            else
            {
                AnsiConsole.Markup("[red]That category does not exist.[/] Please try again. [bold]Enter a valid category:[/] ");
            }
        }
    }
    private static void DisplayMovieTable(List<Movie> movieList)
    {
        var table = new Table();
        table.Border = TableBorder.AsciiDoubleHead;
        table.AddColumn(new TableColumn("Title").Centered());
        table.AddColumn(new TableColumn("Director").Centered());
        table.AddColumn(new TableColumn("Runtime").Centered());
        table.AddColumn(new TableColumn("Year Released").Centered());

        for (int i = 0; i < movieList.Count; i++)
        {
            if (i % 2 == 0)
            {
                var movie = movieList[i];
                table.AddRow(
                    new Markup($"[italic deepskyblue2]{movie.Title}[/]"),
                    new Markup($"{movie.Director}"),
                    new Markup($"[wheat1]{movie.RuntimeMinutes} minutes[/]"),
                    new Markup($"{movie.YearReleased}")
                );
            }
            else
            {
                var movie = movieList[i];
                table.AddRow(
                    new Markup($"[italic deepskyblue3]{movie.Title}[/]"),
                    new Markup($"[grey62]{movie.Director}[/]"),
                    new Markup($"[lightgoldenrod2]{movie.RuntimeMinutes} minutes[/]"),
                    new Markup($"[grey62]{movie.YearReleased}[/]")
                    );
            }
        }
        AnsiConsole.Write(table);
    }
    public static bool ContinueChecker()
    {
        AnsiConsole.Markup("[bold]Would you like to continue? (Y/N): [/]");
        string userInput;

        while (true)
        {
            userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == "y")
            {
                return true;
            }
            else if (userInput == "n")
            {
                AnsiConsole.MarkupLine("[cyan]Goodbye![/]");
                return false;
            }
            AnsiConsole.Markup("[red]Invalid input.[/] Please answer with either '[bold]Y[/]' or '[bold]N[/]': ");
        }
    }
}