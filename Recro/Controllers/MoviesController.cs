using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using DataLayer;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MoviesAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        //Dependecy Injection
        public readonly APIService _movieService;

        public MoviesController(APIService movieService)
        {
            _movieService = movieService;
        }
        //API to hit https://localhost:7293/movies/1
        [HttpGet("{movieId}")]
        public ActionResult<IEnumerable<Movie>> GetMovie(int movieId)
        {
            var movie = _movieService.GetMovie(movieId);

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

