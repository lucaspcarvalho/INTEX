using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intex.Controllers
{
    public class CustomerController : Controller
    {
        [Authorize]
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WorkOrders()
        {
            return View();
        }
        public ActionResult SummaryReport()
        {
            return View();
        }
        public ActionResult RawData()
        {
            return View();
        }
        public ActionResult CompoundDetail()
        {
            return View();
        }
    }
}