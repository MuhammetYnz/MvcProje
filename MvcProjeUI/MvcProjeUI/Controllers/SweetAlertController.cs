using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class SweetAlertController : Controller
    {
        // GET: SweetAlert
        public ActionResult Index()
        {
            //sweetalert.js.org/guides/ sitesinde farklı tipler mevcut
            return View();
        }
    }
}