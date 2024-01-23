using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataLayer
{
    public partial class Movie
    {
        public Movie()
        {
            Reviews = new HashSet<Review>();
            Actors = new HashSet<Actor>();
            Genres = new HashSet<Genre>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; } = null!;
        public int? DirectorId { get; set; }

        public virtual Director? Director { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}
