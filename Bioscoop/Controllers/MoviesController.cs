using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bioscoop.Models;

namespace Bioscoop.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie(0, "Shrek!", 100));
            movies.Add(new Movie(1, "Pokémon", 80));
            movies.Add(new Movie(2, "Three Musketeers", 90));
            movies.Add(new Movie(3, "Mickey Mouse", 110));
            movies.Add(new Movie(4, "100 Arabian Nights", 140));

            return View(movies);
        }

        public ActionResult newMovie()
        {
            return View();
        }
    }
}