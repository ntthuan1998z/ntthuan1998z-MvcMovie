using Microsoft.AspNetCore.Mvc;
using MvcMovie.Services;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _service;

        public MoviesController(IMovieService service) {
            _service = service;
        }

        public IActionResult Index() {
            var movies = _service.GetAll();
            return View(movies);
        }
    }
}