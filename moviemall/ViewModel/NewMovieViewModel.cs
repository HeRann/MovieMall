using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using moviemall.Models;

namespace moviemall.ViewModel
{
    public class NewMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<MovieGenre> MovieGenre { get; set; }
    }
}