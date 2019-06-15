using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArmorOn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
             public ActionResult Gallery()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

             public ActionResult Shop()
             {
                 ViewBag.Message = "Your contact page.";

                 return View();
             }

             public ActionResult Careers()
             {
                 ViewBag.Message = "Your contact page.";

                 return View();
             }
             public ActionResult Clients()
             {
                 ViewBag.Message = "Your contact page.";

                 return View();
             }

             public ActionResult History()
             {
                 ViewBag.Message = "Your contact page.";

                 return View();
             }
             public ActionResult Vision()
             {
                 ViewBag.Message = "Your contact page.";

                 return View();
             }

        public ActionResult SizeChart()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}