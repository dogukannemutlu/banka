using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogukanNemutlu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bankamız hakkında tüm bilgilere bu bölümden ulaşabilirsiniz.";
            
            return View();
        }

       

        public ActionResult Contact()
        {
            ViewBag.Message = "İletişim Bölümü";

            return View();
        }
    }
}