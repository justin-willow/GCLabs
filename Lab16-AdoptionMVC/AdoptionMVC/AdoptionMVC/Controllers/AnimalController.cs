using AdoptionMVC.Models;
using AdoptionMVC.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace AdoptionMVC.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public AnimalController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        private List<string> _GetDistinctBreeds()
        {
            return _appDbContext.Animals.Select(a => a.Breed).Distinct().ToList();
        }

        public IActionResult Index()
        {
            var distinctBreeds = _GetDistinctBreeds();

            return View(distinctBreeds);
        }
        public IActionResult Results(string selectedBreed)
        {
            var matchingAnimals = _appDbContext.Animals.Where(a => a.Breed == selectedBreed).ToList();

            return View(matchingAnimals);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.DistinctBreeds = _GetDistinctBreeds();

            return View();
        }
        [HttpPost]
        public IActionResult Add(Animal newAnimal)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Animals.Add(newAnimal);
                _appDbContext.SaveChanges();
                return RedirectToAction("Confirmation", new { message = "Animal added successfully!" });
            }
            return View(newAnimal);
        }
        [HttpPost]
        public IActionResult Adopt(int id)
        {
            var animalToAdopt = _appDbContext.Animals.Find(id);
            if (animalToAdopt != null)
            {
                _appDbContext.Animals.Remove(animalToAdopt);
                _appDbContext.SaveChanges();
            }
            return RedirectToAction("Confirmation", new { message = "Animal adopted successfully!" });
        }
        public IActionResult Confirmation(string message)
        {
            ViewBag.Message = message;
            return View();
        }
    }
}