using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var Movie = new Models.Movie { Name = "Shrek!" };

            var Customers = new List<Customer>
            {
                new Customer { Name = "Customer1"},
                new Customer { Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Customer = Customers,
                Movie = Movie
            };
            return View(viewModel);
            
            // return View(movie);
           // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int Id)
        {
            return Content("Id=" + Id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
             
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy{1}", pageIndex,sortBy));
        }
        [Route("movies/release/{year}/{month}")] //:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month); 
        }
    }
}