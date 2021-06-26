using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce_App.Models.Database;

namespace eCommerce_App.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Faq()
        {
            return View();
        }

        public ActionResult Page404()
        {
            return View();
        }

        public PartialViewResult GetCategories()
        {
            var categories = c.SubCategories.ToList();
            return PartialView(categories);
        }
    }
}