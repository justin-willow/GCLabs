using Lab19_OMDb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab19_OMDb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MovieService _movieService;
        public HomeController(ILogger<HomeController> logger, MovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MovieSearch()
        {
            return View();
        }
        public IActionResult MovieNight()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MovieSearchResults(string title)
        {
            var movie = await _movieService.GetMovieByTitleAsync(title);
            return View("MovieSearch", movie);
        }
        [HttpPost]
        public async Task<IActionResult> MovieNightResults(string title1, string title2, string title3)
        {
            var titles = new List<string> { title1, title2, title3 };
            var movies = await _movieService.GetMoviesByTitlesAsync(titles);
            return View("MovieNight", movies);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}