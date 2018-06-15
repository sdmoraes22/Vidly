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
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Classificação")]
        public string Classification { get; set; }
        
        public Genre Genre { get; set; }

        [Display(Name = "Data de Lançamento")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range (1, 20)]
        [Display(Name = "Quantidade em Estoque")]
        public int NumberInStock { get; set; }

        public int NumberAvaiable { get; set; }

        [Display(Name = "Gênero")]
        [Required]
        public byte GenreId { get; set; }
    }
}