using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var currentRegion = Environment.GetEnvironmentVariable("REGION_NAME");
            ViewBag.Message = currentRegion == null ? "No Region" : currentRegion;

            return View();
        }

        [HttpGet]
        public ActionResult Status()
        {
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
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