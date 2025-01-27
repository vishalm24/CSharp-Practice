using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        //Get: Movie/Random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Naruto" };
            return View(movie);
        }
        public IActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }
            return Content($"pageIndex = {pageIndex}, sortBy = {sortBy}");
        }
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }
    }
}
