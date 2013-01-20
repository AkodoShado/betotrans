using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Betotrans.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.Redirect(Url.Content("Sprzedaz-kruszyw"));
            return View();
        }

        public ActionResult Offer()
        {
            return View();
        }

        public ActionResult Aggregate()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Reference()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
