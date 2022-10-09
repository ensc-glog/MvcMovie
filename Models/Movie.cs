namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public string Genre { get; set; } = null!;
}