using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
    public class GenreViewModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; }

        public GenreViewModel(int movieId, string title)
        {
            MovieId = movieId;
            Title = title;
        }

        // Add additional properties as needed for the API response
    }
}
