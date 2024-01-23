using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class APIService
    {
        //dependency injection
        //private readonly MovieDatabaseContext _dbContext;

        //public APIService(MovieDatabaseContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public IEnumerable<Movie> GetMovie(int movieId)
        {
            using (var context = new MovieDatabaseContext())
            {
                var movies = context.Movies
                        .Where(m => m.MovieId == movieId)
                        .Include(m => m.Director)
                        .Include(m => m.Actors)
                        .Include(m => m.Genres)
                        .Include(m => m.Reviews)
                        .ToList();

                return movies;
            }
        }
        public IEnumerable<GenreViewModel> GetMoviesByGenre(int genreId)
        {
            using (var context = new MovieDatabaseContext())
            {
                var genre = context.Movies
                .Where(m => m.Genres.Any(g => g.GenreId == genreId));


                var GenreViewModel = genre.Select(movie => new GenreViewModel(movie.MovieId, movie.Title)
                   {
                       // Add other properties as needed
                   }).ToList();

                return GenreViewModel;
            }
        }

        public IEnumerable<Actor> GetMoviesByActor(int actorid)
        {
            using (var context = new MovieDatabaseContext())
            {
                var actor = context.Actors
                .Where(a => a.ActorId == actorid)
                .Include(a => a.Movies)
                .ToList();

                return actor;
            }
        }
    }
}
