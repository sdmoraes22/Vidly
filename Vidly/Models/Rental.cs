using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Rental
    {
        [Required]
        public int RentalId { get; set; }

        [Display(Name = "Data de Locação")]
        [Required]        
        public DateTime DateRented { get; set; }

        [Display (Name = "Data de devolução")]
        public DateTime? DateReturned { get; set; }

        [Required]
        public Movie Movie { get; set; }

        [Required]
        public Customer Customer { get; set; }

    }
}