using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWeb.Models;

namespace VidlyWeb.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {

            List<Movie> movies = new List<Movie> { new Movie { Id = 1, Name="Star Wars 1" },
                                                    new Movie {Id=2, Name="Avengers 1" },
                                                    new Movie {Id=3, Name="Despicable Me 1" } };


            return View(movies);
        }
    }
}