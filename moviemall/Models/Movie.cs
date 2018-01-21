using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace moviemall.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MovieGenre MovieGenre { get; set; }
        public int MovieGenreId { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public int NumberInStock { get; set; }
    }

}