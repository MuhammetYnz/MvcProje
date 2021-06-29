using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery

        ImageFileManager ıfm = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var ımageValues = ıfm.GetList();
            return View(ımageValues);
        }
    }
}