using System;
using System.Collections.Generic;

namespace MoviesAPIs.Models
{
    public partial class Actor
    {
        public Actor()
        {
            Movies = new HashSet<Movie>();
        }

        public int ActorId { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
