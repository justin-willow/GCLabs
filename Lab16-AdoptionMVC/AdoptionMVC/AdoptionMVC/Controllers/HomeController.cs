using AdoptionMVC.Models;
using AdoptionMVC.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdoptionMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var animals = _appDbContext.Animals.ToList();
            Console.WriteLine($"Number of animals retrieved: {animals.Count}");

            return View(animals);
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