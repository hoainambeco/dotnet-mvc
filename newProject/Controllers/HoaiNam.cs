using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers;

public class HoaiNam : Controller
{
    // GET
    public IActionResult Index()
    {
        return View("abc");
    }
}