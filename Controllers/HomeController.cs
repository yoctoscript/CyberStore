using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CyberStore.Models;
using CyberStore.Data;
using Microsoft.AspNetCore.Authorization;

namespace CyberStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [Authorize(Roles = "Member, Moderator, Administrator")]
    public IActionResult Member()
    {
        return View();
    }

    [Authorize(Roles = "Moderator, Administrator")]
    public IActionResult Moderator()
    {
        return View();
    }

    [Authorize(Roles = "Administrator")]
    public IActionResult Administrator()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
