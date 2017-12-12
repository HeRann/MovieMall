using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using moviemall.Models;

namespace moviemall.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Mov { get; set; }
        public List<Customer> Cust { get; set; }
    }
}