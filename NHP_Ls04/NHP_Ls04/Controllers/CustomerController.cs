using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHP_Ls04.Controllers
{
    public class CustomerController : Controller
    {

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        // customer detail
        public  ActionResult CustomerDetail()
        {
            Models.NHPCustomer cus = new Models.NHPCustomer()
            {
                CustomerID = "2210900117",
                FirstName = "Nguyen",
                LastName = "Phuc",
                Address = "Ha Noi",
                YearOfBirth = "2003"
            };
            ViewBag.customer = cus;
            return View();
        }
        public ActionResult ListCustomer()
        {
            List<Models.NHPCustomer> list = new List<Models.NHPCustomer>()
            {
                new Models.NHPCustomer()
                {

                    CustomerID = "2210900117",
                    FirstName = "Nguyen",
                    LastName = "Phuc",
                    Address = "Ha Noi",
                    YearOfBirth = "2003"

                },
                new Models.NHPCustomer()
                {

                    CustomerID = "2210900109",
                    FirstName = "Nguyen",
                    LastName = "Loc",
                    Address = "Ha Noi",
                    YearOfBirth = "2004"

                },
                new Models.NHPCustomer()
                {

                    CustomerID = "2210900107",
                    FirstName = "Nguyen",
                    LastName = "Tinh",
                    Address = "Ha Noi",
                    YearOfBirth = "2003"

                }
            };
            // ViewBag.list = list ;
            return View(list);

        }
        //get: create customer
        public ActionResult CreateCustomer()
        {
            return View();

        }
        [HttpPost]
        public ActionResult CreateCustomer(Models.NHPCustomer cus)
        {
            string infor = "ID:" + cus.CustomerID;
            infor += "<br>Name: " + cus.FirstName + " " + cus.LastName;
            infor += "<br>Address:" + cus.Address;
            infor += "<br>year:" + cus.YearOfBirth;

            return Content(infor);
        }
    }
    
}