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
            //return Content("Hello World!"); // This will only return string to the view 
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home",new { page = 1, sortBy = "name" });
            //return RedirectToAction("Contact", "Home",new { page = 1 });
        }

        //public ActionResult Edit(int idc)
        //{
        //    return Content("Value is = " + idc);

        //}// It must be query string: http://localhost:57447/movies/edit?idc=1

        public ActionResult Edit(int id)
        {
            //return Content(String.Format("Value is = {0}" , id));
            return Content("Value is = {0}"+ id);

        }

        //Nevigate to movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //}
    }
}