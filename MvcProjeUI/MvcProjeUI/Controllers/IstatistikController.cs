using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class IstatistikController : Controller
    {
        Context context = new Context();

        // GET: Istatistik
        public ActionResult Index()
        {
            ViewBag.KategoriToplami =context.Categories.Count().ToString();

            ViewBag.Yazilim = context.Headings.Count(x => x.Category.CategoryName == "Yazılım").ToString(); 

            ViewBag.Yazar = context.Writers.Count(x => x.WriterName.Contains("a")).ToString();

            ViewBag.BasligiEnCokKategori = context.Headings.Select(x => x.Category.CategoryName).Max().ToString();

            
            int truee = context.Categories.Count(x => x.CategoryStatus == true);
            int falsee = context.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.KategoriDurum = truee - falsee;


            return View();
        }
    }
}