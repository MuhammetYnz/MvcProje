﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class WriterPanelContentController : Controller
    {
        // GET: WriterPanelContent

        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult MyContent(string p)
        {
            Context c = new Context();
            p = (string)Session["WriterMail"];
            var writerİdİinfo = c.Writers.Where(x => x.WriterMail == p).Select(y=>y.WriterID).FirstOrDefault();
            var contentValues = cm.GetListByWriter(writerİdİinfo);
            return View(contentValues);
        }
    }
}