using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieApiController : ControllerBase
{
    private readonly MvcMovieContext _context;

    public MovieApiController(MvcMovieContext context)
    {
        _context = context;
    }

    // GET: api/MovieApi
    public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
    {
        return await _context.Movies.ToListAsync();
    }
}
