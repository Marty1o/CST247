/*
 * Chuck Henderson, Reuel Maddela, Harpreet Sidhu
 * CST-247 (Enterprise Applications Programming III)
 * Brandon Bass
 * (This is our work along with the help from On-ground course)
 */


using System.Collections.Generic;
using System.Web.Mvc;
using System;

using Activity7.Models;

namespace Activity7.Controllers
{
    // Implementing controller to CustomerController
    public class CustomerController : Controller
    {
        //List that houses customers created in customer controller
        List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerController()
        {
            // Create a List of Customers
            customers.Add(new CustomerModel(0, "Charles", 29));
            customers.Add(new CustomerModel(1, "Reuel", 22));
            customers.Add(new CustomerModel(2, "Harpreet", 29));
        }

        // GET: Display Main Customer Page
        [HttpGet]
        public ActionResult Index()
        {
            // Display Customer View and pass the List of Customers to the View
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[0]);
            return View("Customer1", tuple);
        }

        // POST: On Select of Customer Radio Button (Non AJAX Form with Partial View and Full Page Update)
        [HttpPost]
        public ActionResult OnSelectCustomer1(string Customer)
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[Int32.Parse(Customer)]);
            return View("Customer1", tuple);

        }

        // POST: On Select of Customer Radio Button (AJAX Form with Partial View and Partial Page Update)
        [HttpPost]
        public PartialViewResult OnSelectCustomer2(string Customer)
        {
            return PartialView("_CustomerDetails", customers[Int32.Parse(Customer)]);
        }

        // POST: Get some data from this Controller method
        [HttpPost]
        public string GetMoreInfo(string Customer)
        {
            // Return some test data back to the Browser
            return "Hello this is some test data";
        }
    }
}