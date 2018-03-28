using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yoyo.ViewModels;

namespace Yoyo.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Form()
        {
            return View(new RequiredTestViewModel());
        }
        [HttpPost]
         public ActionResult Form(RequiredTestViewModel vm)
        {
            return View(new RequiredTestViewModel());
        }

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
    }
}