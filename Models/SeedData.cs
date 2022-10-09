using MvcMovie.Data;

namespace MvcMovie.Models;

public class SeedData
{
    public static void Init()
    {
        using (var context = new MvcMovieContext())
        {
            // Look for existing content
            if (context.Movies.Any())
            {
                return;   // DB already filled
            }

            // Add several movies
            context.Movies.AddRange(
                                new Movie
                                {
                                    Title = "When Harry Met Sally",
                                    ReleaseDate = DateTime.Parse("1989-2-12"),
                                    Genre = "Romantic Comedy",
                                },

                                new Movie
                                {
                                    Title = "Ghostbusters ",
                                    ReleaseDate = DateTime.Parse("1984-3-13"),
                                    Genre = "Comedy",
                                },

                                new Movie
                                {
                                    Title = "Ghostbusters 2",
                                    ReleaseDate = DateTime.Parse("1986-2-23"),
                                    Genre = "Comedy",
                                },

                                new Movie
                                {
                                    Title = "Rio Bravo",
                                    ReleaseDate = DateTime.Parse("1959-4-15"),
                                    Genre = "Western"
                                }
                            );

            // Commit changes into DB
            context.SaveChanges();
        }
    }
}