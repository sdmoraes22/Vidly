using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MoviesFormViewModel
    {
        [Required]
        public int? Movieid { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Classificação")]
        public string Classification { get; set; }

        [Required]
        [Display(Name = "Data de Lançamento")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Quantidade em Estoque")]
        public int? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Gênero")]
        public byte? GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public string Title
        {
            get
            {
                if (Movieid != 0)
                {
                    return "Edit Movie";
                }
                else
                {
                    return "New Movie";
                }
            }
        }


        public MoviesFormViewModel()
        {
            Movieid = 0;
        }

        public MoviesFormViewModel(Movie movie)
        {
            Movieid = movie.Movieid;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            GenreId = movie.GenreId;
            NumberInStock = movie.NumberInStock;
            Classification = movie.Classification;
        }
    }
}