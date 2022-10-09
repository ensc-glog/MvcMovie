using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloController : Controller
{
    // 
    // GET: /Hello/
    public string Index()
    {
        return "Hello World!";
    }

    // GET: /Hello/Welcome/ 
    public string Welcome(string name, int numTimes = 1)
    {
        // Prevents injection attacks
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
}
