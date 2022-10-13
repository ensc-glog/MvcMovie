using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [StringLength(100, MinimumLength = 3)]
    public string Title { get; set; } = null!;

    [Display(Name = "Release Date"), DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [StringLength(30)]
    public string Genre { get; set; } = null!;
}