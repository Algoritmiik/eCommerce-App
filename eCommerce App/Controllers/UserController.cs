using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce_App.Models.Database;
using System.Security.Cryptography;

namespace eCommerce_App.Controllers
{
    public class UserController : Controller
    {

        Context c = new Context();
        SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Users user)
        {
            string password = SHA256Hashing(user.passwordHash);
            if (c.Users.FirstOrDefault(x => x.email == user.email && x.passwordHash == password) != null)
            {
                var currentUser = c.Users.Where(x => x.email == user.email).First();
                currentUser.lastLogin = DateTime.Now;
                c.Entry(currentUser).CurrentValues.SetValues(currentUser);
                c.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Invalid = "Email or password is wrong";
                return View(user);
            }
        }

        [HttpGet]
        public ActionResult Registered()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registered(Users user)
        {
            user.passwordHash = SHA256Hashing(user.passwordHash);
            user.registeredAt = DateTime.Now;
            c.Users.Add(user);
            c.SaveChanges();
            return RedirectToAction("Login");
        }

        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult ForgetPassword()
        {
            return View();
        }

        public string SHA256Hashing(string password)
        {
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }
    }
}