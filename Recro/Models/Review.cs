using System;
using System.Collections.Generic;

namespace MoviesAPIs.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public string Text { get; set; } = null!;
        public int MovieId { get; set; }

        public virtual Movie? Movie { get; set; }
    }
}
