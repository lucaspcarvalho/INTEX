﻿using System;
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
        public ActionResult ProcessBilling()
        {
            return View();
        }
        public ActionResult CustomerInfo()
        {
            return View();
        }
        public ActionResult Discount()
        {
            return View();
        }
        public ActionResult UpdatedCustomerInfo()
        {
            return View();
        }
        public ActionResult Invoice()
        {
            return View();
        }
        public ActionResult UpdateAssayCatalog()
        {
            return View();
        }
        public ActionResult QueryAssayCatalog()
        {
            return View();
        }
        public ActionResult EditAssay()
        {
            return View();
        }
    }
}