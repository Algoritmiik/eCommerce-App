using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce_App.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Beverages()
        {
            return View();
        }

        public ActionResult Groceries()
        {
            return View();
        }

        public ActionResult Household()
        {
            return View();
        }

        public ActionResult PersonalCare()
        {
            return View();
        }

        public ActionResult PackagedFoods()
        {
            return View();
        }

        public ActionResult Gourmet()
        {
            return View();
        }
    }
}