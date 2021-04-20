using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce_App.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Products()
        {
            return View();
        }

        public ActionResult Single()
        {
            return View();
        }

        public ActionResult Offers()
        {
            return View();
        }
    }
}