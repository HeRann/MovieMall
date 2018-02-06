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

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public MovieGenre MovieGenre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int MovieGenreId { get; set; }

        [Required]
        [Display (Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,500, ErrorMessage = "The field Number in Stock must be between 1 and 500")]
        [Display (Name ="Number in Stock")]
        public int NumberInStock { get; set; }
    }

}