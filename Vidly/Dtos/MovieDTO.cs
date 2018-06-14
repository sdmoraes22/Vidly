using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDTO
    {
        [Required]
        public int Movieid { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Classificação")]
        public string Classification { get; set; }

        [Display(Name = "Data de Lançamento")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Quantidade em Estoque")]
        public int NumberInStock { get; set; }

        [Display(Name = "Gênero")]
        [Required]
        public byte GenreId { get; set; }
    }
}