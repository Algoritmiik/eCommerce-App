using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce_App.Models.Database;


namespace eCommerce_App.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        Context c = new Context();

        // GET: Admin
        public ActionResult Index()
        {
            var userName = User.Identity.Name;
            var currentUser = c.Users.Where(x => x.userName == userName).First();
            var subCategories = c.SubCategories.ToList();
            if (currentUser.isAdmin == true)
            {
                return View(subCategories);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult ProductRegister(Products product)
        {
            c.Products.Add(product);
            c.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }
    }
}