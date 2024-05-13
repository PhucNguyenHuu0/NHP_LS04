using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHP_Ls04.Controllers
{
    public class NHPCustomerScaffdingController : Controller
    {
        //mockdata
        private static List<NHP_Ls04.Models.NHPCustomer> ListCustomer = new List<NHP_Ls04.Models.NHPCustomer>()
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
        // GET: NHPCustomerScaffding
        //listcustomer
        public ActionResult Index()
        {
            return View(ListCustomer);
        }
        public ActionResult NHPCreate()
        {
            var model = new Models.NHPCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult NHPCreate(Models.NHPCustomer model)
        {
            // them moi doi tuong khach hang vao ds du lieu
            ListCustomer.Add(model);
            //return View(model);
            //chuyen ve trang danh sach
            return RedirectToAction("index");

        }
        public ActionResult NHPEdit(int id)
        {

            var Customer = ListCustomer.FirstOrDefault();
            return View(Customer);
        }
        public ActionResult NHPDelete(int id)
        {
            var Customer = ListCustomer.FirstOrDefault();
            return View(Customer);
        }
       
    }
}