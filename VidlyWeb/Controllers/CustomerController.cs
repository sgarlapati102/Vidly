using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWeb.Models;

namespace VidlyWeb.Controllers
{
    public class CustomerController : Controller
    {
     
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer> { new Customer { Id = 1, Name = "Srini" },
                                                            new Customer {Id=2, Name="Archana" },
                                                            new Customer {Id=3,Name="Smaran" } };


            return View(customers);
        }

        public ActionResult Details(int Id)
        {

            
            List<Customer> customers = new List<Customer> { new Customer { Id = 1, Name = "Srini" },
                                                            new Customer {Id=2, Name="Archana" },
                                                            new Customer {Id=3,Name="Smaran" } };
            Customer cust = customers.Find(c=> c.Id==Id);

            return View(cust);
        }
        
    }
}