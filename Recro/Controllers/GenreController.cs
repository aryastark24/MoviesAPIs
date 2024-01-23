using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using System.Text.Json.Serialization;
using System.Text.Json;
using DataLayer.Models;


namespace MoviesAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : ControllerBase
    {
        //Dependecy Injection
        public readonly APIService _movieService;

        public GenreController(APIService movieService)
        {
            _movieService = movieService;
        }
        //API to Hit https://localhost:7293/genre/1
        [HttpGet("{genreId}")]
        public ActionResult<IEnumerable<Movie>> GetMoviesByGenre(int genreId)
        {
            //● Implement an API endpoint to list all movies by a genre.

            var genre = _movieService.GetMoviesByGenre(genreId);

            if (genre == null)
            {
                return NotFound();
            }
            return Ok(genre);
        }
    }
}
