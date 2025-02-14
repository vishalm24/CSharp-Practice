using Microsoft.AspNetCore.Mvc;
using RoutingDemo.Models;

namespace RoutingDemo.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult ByReleasedDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }
        public IActionResult Index()
        {
            var movie = new Movie() { name = "shrek!" };
            var randomModel = new RandomMovieModel { _movie = movie };
            return View(randomModel);
        }
        [Route("movies/released/{year:yearRange}/{month:int:range(1,12)}")]
        public IActionResult CheckDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }
    }
}
