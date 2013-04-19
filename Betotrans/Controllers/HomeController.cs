using Betotrans.Models;
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

        public ActionResult Kruszywo(string nazwa)
        {
            var model = new KruszywoViewModel()
            {
                Title = "Pospółka",
                Img = Url.Content("~/Images/kruszywa/pospolka.jpg"),
                MiniImg = Url.Content("~/Images/kruszywa/mini/pospolka_195x145.jpg"),
                Size = "0,075 - 63 mm",
                Description = "Pospółka to grunt rodzimy mineralny zbliżony do piasku i żwiru ( materiał pochodzenia naturalnego ) sypki i niesortowany. Materiał ten charakteryzuje się zawartością sumy frakcji żwirowej i kamienistej pomiędzy 10 a 50% . Uziarnienie graniczne pospółki od 0,075 mm do 63 mm. Ze względu na dobre właściwości filtracyjne, mechaniczne  i dużą nośność pospółka jest często wykorzystywana w  budownictwie jako materiał na podbudowy pod fundamenty, w drogownictwie do wykonania warstw odsączających nasypów drogowych i do betonów zwykłych.  Po wypłukaniu nadaje się świetnie na składnik wysokiej jakości betonów. Doskonałe zagęszczanie pospółki  w sprawach budownictwa drogowego jest równie ważne, co wysoka przepuszczalność wody czy mrozoodporność.",
                IntendedFor = "wylewek ręcznych, wylewania schodów, nadproży, cokolików, tarasów"
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
