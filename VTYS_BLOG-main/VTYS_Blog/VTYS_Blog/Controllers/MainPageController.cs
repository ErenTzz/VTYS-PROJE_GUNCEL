using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VTYS_Blog.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        public ActionResult Menu_Layout()
        {
            return View();
        }
        
        public ActionResult Anasayfa()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult İletişim()
        {
            return View();
        }

        public ActionResult Hakkımızda()
        {
            return View();
        }

        public ActionResult SatınAlma()
        {
            return View();
        }



    }
}