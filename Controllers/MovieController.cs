using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Controllers;

public class MovieController : Controller
{
    private readonly MvcMovieContext _context;

    public MovieController(MvcMovieContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var movies = await _context.Movies.OrderBy(m => m.Title).ToListAsync();

        return View(movies);
    }
}
