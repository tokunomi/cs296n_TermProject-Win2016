using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatTales.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "You love cats; we do, too!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here's how to contact us:";

            return View();
        }
    }
}