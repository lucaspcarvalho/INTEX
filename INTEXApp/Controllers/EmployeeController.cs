using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEXApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/AddCustomer
        public ActionResult AddCustomer()
        {
            return View();
        }
        // GET: Employee/AddCustomer
        public ActionResult AddQuote()
        {
            return View();
        }
    }
}