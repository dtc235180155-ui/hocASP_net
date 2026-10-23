using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class HelloController : Controller
{
    // GET: /Hello/
    public IActionResult Index()
    {
        return View();
    }

    // GET: /Hello/Welcome?name=Rick&numtimes=4
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}
