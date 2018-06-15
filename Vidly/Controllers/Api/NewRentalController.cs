using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        private VidlyContext _context;

        public NewRentalController()
        {
            _context = new VidlyContext();
        }

        //Get /api/newrental
        [HttpPost]
        public IHttpActionResult CreateRentals(NewRentalDTO newRental)
        {

            var customer = _context.Customers.Single(c => c.Customerid == newRental.CustomerId);

            var movies = _context
                .Movies
                .Where(m => newRental.MoviesIds.Contains(m.Movieid))
                .ToList();
            
            foreach (var movie in movies)
            {
                if(movie.NumberAvaiable == 0)
                {
                    return BadRequest("Movie is not avaiable");
                }
                movie.NumberAvaiable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
        }

    }
}
