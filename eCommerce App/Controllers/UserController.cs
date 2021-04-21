using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce_App.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registered()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult ForgetPassword()
        {
            return View();
        }
    }
}