using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Customerid = 1, Name = "John"},
                new Customer { Customerid = 2, Name = "Mary"}
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);            
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Customerid = 1, Name = "John"},
                new Customer { Customerid = 2, Name = "Mary"}
            };

            var customer = customers.ElementAt(id - 1);
            return View(customer);
        }
    }
}