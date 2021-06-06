using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce_App.Models.Database;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Globalization;

namespace eCommerce_App.Controllers
{
    public class ProfileController : Controller
    {

        Context c = new Context();
        SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();

        // GET: Profile
        public ActionResult Profile()
        {
            return View();
            
        }

        public ActionResult MyAccount()
        {
            return View();
        }

        public ActionResult CreditCards()
        {
            var allCards = c.CreditCards.ToList(); // Where eklenecek 
            return View(allCards);
        }

        [HttpPost]
        public ActionResult CreditCardRedirect()
        {
            return RedirectToAction("CreditCards");
        }

        public ActionResult Addresses()
        {
            var allAddresses = c.UserAddresses.ToList();
            return View(allAddresses);
        }

        [HttpPost]
        public ActionResult AddressRedirect()
        {
            return RedirectToAction("Addresses");
        }

        public ActionResult UpdateInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateAccountRedirect()
        {
            return RedirectToAction("UpdateInfo");
        }

        public ActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ResetPasswordRedirect()
        {
            return RedirectToAction("ResetPassword");
        }

        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult CurrentOrders()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CurrentOrdersRedirect()
        {
            return RedirectToAction("CurrentOrders");
        }

        public ActionResult PastOrders()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PastOrdersRedirect()
        {
            return RedirectToAction("PastOrders");
        }

        public ActionResult RatingsComments()
        {
            return View();
        }

        public ActionResult Ratings()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RatingsRedirect()
        {
            return RedirectToAction("Ratings");
        }

        public ActionResult Comments()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CommentsRedirect()
        {
            return RedirectToAction("Comments");
        }

        public string SHA256Hashing(string password)
        {
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }
    }
}