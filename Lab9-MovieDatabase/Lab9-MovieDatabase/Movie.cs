namespace Lab9_MovieDatabase;
public class Movie
{
    public string Title { get; set; }
    public Categories Category { get; set; }
    public int RuntimeMinutes { get; set; }
    public int YearReleased { get; set; }
    public string Director { get; set; }

    public Movie(string title, Categories category, int runtimeMinutes, int yearReleased, string director)
    {
        this.Title = title;
        this.Category = category;
        this.RuntimeMinutes = runtimeMinutes;
        this.YearReleased = yearReleased;
        this.Director = director;
    }
}