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
            var customers = from m in dataContext.Customers
                            select m;

            return View(customers);
        }

    }
}
