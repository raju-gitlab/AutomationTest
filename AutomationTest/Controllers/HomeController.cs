using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public bool Can_view_page(string usertype)
        {
            if (usertype.ToLower() == "admin")
            {
                return true;
            }
            else if(usertype.ToLower() == "user")
            {
                return true;
            }
            return false;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}