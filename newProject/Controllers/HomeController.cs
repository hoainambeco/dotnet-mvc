using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newProject.Models;

namespace newProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int x, string s)
    {
        const string name = "Nguyễn Hoài Nam";
        ViewBag.age = 18;
        ViewData["name2"] = "Quân ngu";
        TempData["Name"] = name;
        TempData["path"] = x;
        TempData["s"] = s;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PostUser()
    {
        _logger.Log(LogLevel.Debug,"start");
        return View();
    }
    [HttpPost]
    public IActionResult PostUser(User user)
    {
        return View(user);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}