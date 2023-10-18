using Lab17_DeckCards.Models;
using Lab17_DeckCards.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab17_DeckCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDeckCardsService _deckCardsService;
        public HomeController(ILogger<HomeController> logger, IDeckCardsService deckCardsService)
        {
            _logger = logger;
            _deckCardsService = deckCardsService;
        }

        public async Task<IActionResult> Index()
        {
            string deckId = await _deckCardsService.CreateNewDeckAsync();
            var cards = await _deckCardsService.GetCardsAsync(deckId);

            return View(cards);
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