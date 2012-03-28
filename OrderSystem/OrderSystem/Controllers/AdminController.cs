using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderSystem.Models;


namespace OrderSystem.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Customers()
        {
            var dataContext = new CustomerDataContext();
            var customers = from m in dataContext.Customers select m;
            return View(customers);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Customers(string Email, string ID)
        {
            var dataContext = new CustomerDataContext();
            if (Email != string.Empty)
            {

                var customers = dataContext.Customers.Where(m => m.CustomerEmail.ToUpper().Equals(Email));
                return View(customers);
            }
            else if (ID != string.Empty)
            {
                var customers = dataContext.Customers.Where(m => m.CustomerID.Equals(ID));
                return View(customers);
            }
            else
            {
                var customers = from m in dataContext.Customers select m;
                return View(customers);
            }
        }
    }
}
