using Betotrans.DataAccess.Services;
using Betotrans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Betotrans.Controllers
{
    public class HomeController : Controller
    {
        private readonly AggregateService _aggregateService;

        public HomeController()
        {
            _aggregateService = new AggregateService();
        }

        public ActionResult Index()
        {
            Response.Redirect(Url.Content("Sprzedaz-kruszyw"));
            return View();
        }

        public ActionResult Offer()
        {
            return View();
        }

        public ActionResult Kruszywo(string nazwa)
        {
            var kruszywo = _aggregateService.Get(nazwa);
            var model = new KruszywoViewModel()
            {
                Title = kruszywo.AggregateTitle,
                ImgUrl = kruszywo.ImgUrl,
                MiniImgUrl = kruszywo.MiniImgUrl,
                Size = kruszywo.Size,
                Description = kruszywo.Description,
                IntendedFor = kruszywo.IntendedFor,
            };
            return View(model);
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
