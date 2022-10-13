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

    // GET: Movie
    public async Task<IActionResult> Index()
    {
        var movies = await _context.Movies.OrderBy(m => m.Title).ToListAsync();

        return View(movies);
    }

    // GET: Movies/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var movie = await _context.Movies
            .FirstOrDefaultAsync(m => m.Id == id);
        if (movie == null)
        {
            return NotFound();
        }

        return View(movie);
    }
}
