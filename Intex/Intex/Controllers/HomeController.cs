using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String username = form["Username"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(username, "customer") && (string.Equals(password, "customer1")))
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);

                return RedirectToAction("Index", "Customer");

            }
            else if (string.Equals(username, "employee") && (string.Equals(password, "employee1")))
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);

                return RedirectToAction("Index", "Employee");

            }
            else
            {
                return View();
            }
        }



    }
}