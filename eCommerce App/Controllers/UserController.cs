using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce_App.Models.Database;

namespace eCommerce_App.Controllers
{
    public class UserController : Controller
    {

        Context c = new Context();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Users user)
        {
            var datas = c.Users.FirstOrDefault(x => x.email == user.email && x.passwordHash == user.passwordHash);
            if(datas != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Invalid = "Email or password is wrong";
                return View(user);
            }
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