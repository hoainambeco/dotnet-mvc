using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers;

public class Login : Controller
{
    // GET
    [Route("sign-in")]
    [Route("abc/def" , Name = "login")]
    public IActionResult Index(string a)
    {
        TempData["a"] = a;
        return View();
    }
}