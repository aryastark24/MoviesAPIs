using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MoviesAPIs.Models;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MoviesAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        //API tto hit https://localhost:7293/movies/1
        [HttpGet("{movieId}")]

        public ActionResult<IEnumerable<Movie>> GetMovie(int movieId)
        {

            using (var context = new MovieDatabaseContext())
            {
                //● Implement an API endpoint to retrieve a movie with all details of the movie -
                //actors, director, genre, reviews.
                var movie = context.Movies
                .Where(m => m.MovieId == movieId)
                .Include(m => m.Director)
                .Include(m => m.Actors)
                .Include(m => m.Genres)
                .Include(m => m.Reviews)
                .ToList();

                if (movie == null)
                {
                    return NotFound();
                }

                var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve,
                    MaxDepth = 32
                };

                var json = JsonSerializer.Serialize(movie, options);

                return new ContentResult
                {
                    Content = json,
                    ContentType = "application/json"
                };
            }
        }
    }
}
