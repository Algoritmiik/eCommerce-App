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
using System.Web.Security;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace eCommerce_App.Controllers
{
    [Authorize]
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
            return View();
        }

        [HttpPost]
        public ActionResult CreditCards(Users user,CreditCards card)
        {
            if (c.CreditCards.Where(x => x.creditCardId == card.creditCardId).First() != null)
            {
                try
                {
                    var currentCardHolder = c.CreditCards.Where(x => x.creditCardId == card.creditCardId).First();
                    var currentUser = c.Users.Where(x => x.userName == user.userName).First();

                    currentCardHolder.cardNumber = card.cardNumber;
                    currentCardHolder.creditCardName = card.creditCardName;
                    currentCardHolder.CVV = card.CVV;
                    currentCardHolder.holderName = card.holderName;
                    currentCardHolder.expireDate = card.expireDate;
                    currentCardHolder.userId = card.userId; // burada sıkıntı var user Id almıyor
                    c.Entry(currentCardHolder).CurrentValues.SetValues(currentCardHolder);
                    c.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                    throw;
                }
               
            }
            else if (c.CreditCards.Where(x => x.creditCardId == card.creditCardId).First() == null)
            {
                var newCardHolder = c.CreditCards.Where(x => x.userId == card.userId).First();
                newCardHolder.cardNumber = card.cardNumber;
                newCardHolder.creditCardName = card.creditCardName;
                newCardHolder.CVV = card.CVV;
                newCardHolder.holderName = card.holderName;
                newCardHolder.expireDate = card.expireDate;
                newCardHolder.userId = card.userId;
                c.CreditCards.Add(newCardHolder);
                c.SaveChanges();
            }
            else
            {
                return RedirectToAction("Profile");
            }
            return RedirectToAction("Profile");
        }

        [HttpPost]
        public ActionResult CreditCardRedirect()
        {
            return RedirectToAction("CreditCards");
        }

        public ActionResult Addresses()
        {
            return View();
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
        public ActionResult UpdateInfo(Users user)
        {
            var currentUser = c.Users.Where(x => x.userName == user.userName).First();
            currentUser.firstName = user.firstName;
            currentUser.lastName = user.lastName;
            currentUser.phoneNumber = user.phoneNumber;
            currentUser.email = user.email;
            c.Entry(currentUser).CurrentValues.SetValues(currentUser);
            c.SaveChanges();
            return RedirectToAction("Profile");
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
        public ActionResult ResetPassword(Users user)
        {
            string password = SHA256Hashing(user.passwordHash);
            var currentUser = c.Users.Where(x => x.userName == user.userName).First();
            currentUser.passwordHash = password;
            c.Entry(currentUser).CurrentValues.SetValues(currentUser);
            c.SaveChanges();
            return RedirectToAction("Profile");
        }


        [HttpPost]
        public ActionResult ResetPasswordRedirect()
        {
            return RedirectToAction("ResetPassword");
        }

        public string SHA256Hashing(string password)
        {
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }
    }
}