using Microsoft.AspNetCore.Mvc;

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
            return Content("Hello World!");
        }
    }
}
