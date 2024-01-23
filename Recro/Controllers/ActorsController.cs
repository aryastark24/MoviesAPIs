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
    public class ActorController : ControllerBase
    {
        //Dependecy Injection
        public readonly APIService _movieService;

        public ActorController(APIService movieService)
        {
            _movieService = movieService;
        }
        // ApI to hit https://localhost:7293/actor/1
        [HttpGet("{actorid}")]
        public ActionResult<IEnumerable<Actor>> GetMoviesByActor(int actorid)
        {
            //● Implement an API endpoint to list all movies by a genre.

            var actor = _movieService.GetMoviesByActor(actorid);

            if (actor == null)
            {
                return NotFound();
            }
            var options = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve,
                    MaxDepth = 32
                };

             var json = JsonSerializer.Serialize(actor, options);

             return new ContentResult
                {
                    Content = json,
                    ContentType = "application/json"
                };
            }
        }
    }
