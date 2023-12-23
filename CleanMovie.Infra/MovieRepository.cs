using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infra
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie {Id = 1, Name="Avengers", Cost=19.9m},
            new Movie {Id = 2, Name="Equalizer", Cost=29.9m},
        };

        public List<Movie> GetAllMovies()
        {
            return Movies;
        }
    }
}
