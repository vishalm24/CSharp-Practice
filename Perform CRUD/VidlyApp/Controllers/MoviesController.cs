using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;

namespace VidlyApp.Controllers
{
    public class MoviesController : Controller
    {
        [Route("Movies/Index")]
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie{ Id = 1, Name = "Shrek"},
                new Movie{ Id = 2, Name = "Baby's Day Out"},
                new Movie{ Id = 3, Name = "Cars"},
                new Movie{ Id = 4, Name = "Iron Man"},
                new Movie{ Id = 5, Name = "The Avengers"},
                new Movie{ Id = 6, Name = "Wall-e"},
                new Movie{ Id = 7, Name = "Tarzen"}
            };
            return View(movies);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Shrek" };
            //Sending multiple parameters from model:
            var customer = new List<Customer>
            {
                new Customer{ Id =  1,  Name = "Vishal" },
                new Customer{ Id = 2,  Name = "Shubham"}
            };
            var viewModel = new RandomViewModel
            {
                Movie = movie,
                Customers = customer
            };
            return View(viewModel);

            ////Following things are used for passing parameters:
            ////ViewData:
            //ViewData["Movie"] = movie;
            //return View();
            ////ViewBag:
            //ViewBag.Movie = movie;
            //return View();
            ////Model:
            //return View(movie);
        }
        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue) pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";
        //    return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        //}
        [Route("Movies/Released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}