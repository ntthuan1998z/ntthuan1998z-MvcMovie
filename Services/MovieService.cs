using System.Collections.Generic;
using System.Linq;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieContext _context;

        public MovieService(MovieContext context) {
            _context = context;
        }
        IEnumerable<Movie> IMovieService.GetAll()
        {
            return _context.Movies.ToList();
        }
    }
}