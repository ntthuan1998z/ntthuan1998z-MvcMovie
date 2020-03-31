using System.Collections.Generic;
using MvcMovie.Models;

namespace MvcMovie.Services
{
    public interface IMovieService
    {
         IEnumerable<Movie> GetAll();
    }
}