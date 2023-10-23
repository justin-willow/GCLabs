using Lab19_OMDb.Models.Interfaces;

namespace Lab19_OMDb.Models;

public class MovieService : IMovieService
{
    private readonly string _apiKey = "a4fa6cf2";

    public async Task<MovieResponse> GetMovieByTitleAsync(string title)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string apiUrl = $"http://www.omdbapi.com/?apikey={_apiKey}&t={title}&type=movie";
                var movieResponse = await client.GetFromJsonAsync<MovieResponse>(apiUrl);
                return movieResponse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
    public async Task<List<MovieResponse>> GetMoviesByTitlesAsync(List<string> titles)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                var movieResponses = new List<MovieResponse>();

                foreach (var title in titles)
                {
                    string apiUrl = $"http://www.omdbapi.com/?apikey={_apiKey}&t={title}&type=movie";
                    var movieResponse = await client.GetFromJsonAsync<MovieResponse>(apiUrl);
                    movieResponses.Add(movieResponse);
                }
                return movieResponses;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}