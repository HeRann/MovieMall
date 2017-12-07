using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using moviemall.Models;

namespace moviemall.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie();
            movie.Name = "Jurassic World";
            return View(movie);
        }
    }
}