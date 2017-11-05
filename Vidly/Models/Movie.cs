﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Movieid { get; set; }
        public string Name { get; set; }
        public string Classification { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}