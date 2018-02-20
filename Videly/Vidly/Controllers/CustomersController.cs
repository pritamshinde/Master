using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Get()
        {
            var customers = new List<Models.Customer>
            {
              new Customer { Id = 1, Name = "Customer1" },
              new Customer {Id =2,Name="Customer2" }
            };

            var getCustomer = new ViewModels.RandomMovieViewModel
            {
                Customer = customers

            };
            return View(getCustomer);
        }

        public ActionResult Edit(int Id)
        {
            return Content("Id=" + Id);
        }
    }
}