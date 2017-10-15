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
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Movieid = 1, Name = "Shrek!"},
                new Movie {Movieid = 2, Name = "Terminator!"}
            };

            var viewModel = new MoviesViewModel
            {
                Movie = movies
            };
        
            return View(viewModel);
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var movies = new List<Movie>
            {
                new Movie {Movieid = 1, Name = "Shrek!"},
                new Movie {Movieid = 2, Name = "Terminator!"}
            };


            var movie = movies.ElementAt(id - 1);
            return View(movie);
        }
    }
}