using Lab9_MovieDatabase;
using Spectre.Console;

var movies = new List<Movie>
{
    new Movie("Klaus", Categories.ANIMATED, 96, 2019, "Sergio Pablos"),
    new Movie("Princess Mononoke", Categories.ANIMATED, 134, 1997, "Hayao Miyazaki"),
    new Movie("Nausicaa of the Valley of the Wind", Categories.ANIMATED, 117, 1984, "Hayao Miyazaki"),

    new Movie("The Fall", Categories.DRAMA, 117, 2006, "Tarsem Singh"),
    new Movie("Green Knight", Categories.DRAMA, 130, 2021, "David Lowery"),
    new Movie("The Man Who Killed Don Quixote", Categories.DRAMA, 132, 2018, "Terry Gilliam"),
    new Movie("Gladiator", Categories.DRAMA, 155, 2000, "Ridley Scott"),

    new Movie("Pan's Labyrinth", Categories.HORROR, 118, 2006, "Guillermo del Toro"),
    new Movie("Sleepy Hollow", Categories.HORROR, 105, 1999, "Tim Burton"),
    new Movie("Alien", Categories.HORROR, 117, 1979, "Ridley Scott"),

    new Movie("Her", Categories.SCIFI, 126, 2013, "Spike Jonze"),
    new Movie("Blade Runner", Categories.SCIFI, 117, 1982, "Ridley Scott"),
    new Movie("Brazil", Categories.SCIFI, 132, 1985, "Terry Gilliam")
};

AnsiConsole.MarkupLine($"[bold cyan]Welcome to the Movie List Application! [/]");
AnsiConsole.MarkupLine($"There are [bold lightgoldenrod2]{movies.Count}[/] movies in this list.");

bool shouldContinue = true;

while (shouldContinue)
{
    var categoryList = UserInteraction.DisplayMenu(movies);
    AnsiConsole.MarkupLine("Enter the category name or number to make your choice.");
    Console.Write("What category are you interested in?: ");
    UserInteraction.DisplayMovies(movies);

    shouldContinue = UserInteraction.ContinueChecker();
}