using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;

namespace VidlyApp.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("Customers/Index")]
        public ActionResult Index()
        {
            var customer = new List<Customer>
            {
                new Customer{ Id = 1, Name = "Vishal"},
                new Customer{ Id = 2, Name = "Bhavesh"},
                new Customer{ Id = 3, Name = "Dinesh"},
                new Customer{ Id = 4, Name = "Prithviraj"},
                new Customer{ Id = 5, Name = "Omake"},
                new Customer{ Id = 6, Name = "Jitesh"}
            };
            return View(customer);
        }
    }
}