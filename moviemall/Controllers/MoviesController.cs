﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using moviemall.Models;
//using moviemall.ViewModel;

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


        public ActionResult Index()
        {
            var moviesInIndex = getMovies();
            return View(moviesInIndex);
        }

        private IEnumerable<Movie> getMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id =1, Name ="Wall-E"
                },
                new Movie
                {
                    Id = 2,
                    Name ="IT Follows"
                }
            };
        }            
    }
}