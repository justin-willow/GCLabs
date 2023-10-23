namespace Lab19_OMDb.Models.Interfaces;

public interface IMovieService
{
    Task<MovieResponse> GetMovieByTitleAsync(string title);
    Task<List<MovieResponse>> GetMoviesByTitlesAsync(List<string> titles);
}