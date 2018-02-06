using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using moviemall.Models;
using System.Data.Entity;
using moviemall.ViewModel;
using System.Data.Entity.Validation;

namespace moviemall.Controllers
{
    public class MoviesController : Controller
    {
        ////get: movies/random
        //public ActionResult random()
        //{
        //    var m = new Movie();
        //    m.Name = "jurassic world";
        //    List<Customer> c = new List<Customer>();
        //    c.Select(x => x.Name = "Customer 1");
        //    c.Select(x => x.Name = "Customer 2");

        //    var viewmodel = new RandomMovieViewModel();
        //    viewmodel.mov = m;
        //    viewmodel.Cust = c;

        //    return View(viewmodel);
        //    //return content("hello world!"); // this will only return string to the view 
        //    //return httpnotfound();
        //    //return new emptyresult();
        //    //return redirecttoaction("index", "home",new { page = 1, sortby = "name" });
        //    //return redirecttoaction("contact", "home",new { page = 1 });
        //}

        //public ActionResult Edit(int idc)
        //{
        //    return Content("Value is = " + idc);

        //}// It must be query string: http://localhost:57447/movies/edit?idc=1

        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult Index()
        {
            var moviesInIndex = _context.Movies.Include(m => m.MovieGenre).ToList();
            return View(moviesInIndex);
        }


        public ActionResult Details(int ID)
        {
            var moviesInDetails = _context.Movies.Include(m => m.MovieGenre).SingleOrDefault(m => m.Id == ID);
            
            return View(moviesInDetails);
        }
        //private IEnumerable<Movie> getMovies()
        //{
        //    return _context.Movies;
        //    //return new List<Movie>
        //    //{
        //    //    new Movie
        //    //    {
        //    //        Id =1, Name ="Wall-E"
        //    //    },
        //    //    new Movie
        //    //    {
        //    //        Id = 2,
        //    //        Name ="IT Follows"
        //    //    }
        //    //};
        //}            


        public ActionResult New()
        {
            var movieInNew = _context.MovieGenres.ToList();
            var viewModel = new NewMovieViewModel();
            //if (Id == null)
            //{
           // viewModel.Movie = new Movie();
            viewModel.MovieGenre = movieInNew;

                viewModel.MovieGenre = movieInNew;
                ViewData["typeofUpdate"] = "New";
                return View("MovieForm", viewModel);
            //}
        }
        public ActionResult Edit(int Id)
        {
            var movieInEdit = _context.Movies.SingleOrDefault(c => c.Id == Id);
            if (movieInEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                var viewModel = new NewMovieViewModel();
                viewModel.Movie = movieInEdit;
                viewModel.MovieGenre = _context.MovieGenres.ToList();
                ViewData["typeofUpdate"] = "Edit";
                return View("MovieForm", viewModel);
            }
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewMovieViewModel();
                viewModel.Movie = movie;
                viewModel.MovieGenre = _context.MovieGenres.ToList();
                return View("MovieForm",viewModel);
            }
            if (movie.Id == 0)
            {
                 movie.DateAdded = DateTime.Now.Date;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate.Date;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.MovieGenreId = movie.MovieGenreId;
             
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Movies");
        }
      }
}
