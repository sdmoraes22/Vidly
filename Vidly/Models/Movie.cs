using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int Movieid { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Classification { get; set; }
        
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}