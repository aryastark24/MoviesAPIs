using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPIs.Models;

namespace MoviesAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : ControllerBase
    {
        //API to Hit https://localhost:7293/genre/1
        [HttpGet("{genreId}")]
        public ActionResult<IEnumerable<Movie>> GetMoviesByGenre(int genreId)
        {
            using (var context = new MovieDatabaseContext())
            {
                //● Implement an API endpoint to list all movies by a genre.

                var movies = context.Movies
                .Where(m => m.Genres.Any(g => g.GenreId == genreId))
                .ToList();

                return movies;
            }
        }
    }
}
