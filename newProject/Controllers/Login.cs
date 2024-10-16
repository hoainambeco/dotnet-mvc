using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers;

public class Login : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}