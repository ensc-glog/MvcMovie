using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloController : Controller
{
    // 
    // GET: /Hello/
    public IActionResult Index()
    {
        return View();
    }

    // ...
    // GET: /Hello/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 0)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;

        return View();
    }
}
