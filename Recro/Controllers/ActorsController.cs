using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace MoviesAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorController : ControllerBase
    {
        // ApI to hit https://localhost:7293/actor/1
        [HttpGet("{actorid}")]
        public ActionResult<IEnumerable<Actor>> GetMovie(int actorid)
        {

            using (var context = new MovieDatabaseContext())
            {
                //● Implement an API endpoint to retrieve an actor with a list of all movies.
                var actor = context.Actors
                .Where(a => a.ActorId == actorid)
                .Include(a => a.Movies)
                .ToList();

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
}
