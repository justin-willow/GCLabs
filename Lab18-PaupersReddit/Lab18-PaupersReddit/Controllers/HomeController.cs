using Lab18_PaupersReddit.Models;
using Lab18_PaupersReddit.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab18_PaupersReddit.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRedditService _redditService;
    public HomeController(ILogger<HomeController> logger, IRedditService redditService)
    {
        _logger = logger;
        _redditService = redditService;
    }

    public async Task<IActionResult> Index()
    {
        var redditPosts = await _redditService.GetRedditPostsAsync();

        return View(redditPosts);
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