using Activity_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity_3.Controllers
{
    public class CustomerController : Controller
    { 
        List<CustomerModel> list = new List<CustomerModel>();

        public CustomerController()
        {
            list.Add(new CustomerModel(0, "Martin", 23));
            list.Add(new CustomerModel(1, "Eli", 20));
            list.Add(new CustomerModel(2, "Uli", 18));
            list.Add(new CustomerModel(2, "Joach", 30));
        }

        public ActionResult Index()
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(list, list[0]);
            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer1(string Customer)
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(list, list[Int32.Parse(Customer)]);
            return View("Customer", tuple);

        }

        [HttpPost]
        public PartialViewResult OnSelectCustomer2(string Customer)
        {
            return PartialView("_CustomerDetails", list[Int32.Parse(Customer)]);
        }

        [HttpPost]
        public string GetMoreInfo(string Customer)
        {
            return "TESTING!!!";
        }


    }
}