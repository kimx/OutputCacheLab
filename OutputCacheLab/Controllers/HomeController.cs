using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutputCacheLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = $"Home:{DateTime.Now}";
            return View();
        }

        const int duration = 120;
        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Any, Duration = duration)]
        public ActionResult Any()
        {
            ViewBag.Message = $"Any:{DateTime.Now}";
            return View("CacheView");
        }

        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Client, Duration = duration)]
        public ActionResult Client()
        {
            ViewBag.Message = $"Client:{DateTime.Now}";
            return View("CacheView");
        }

        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Downstream, Duration = duration)]
        public ActionResult Downstream()
        {
            ViewBag.Message = $"Downstream:{DateTime.Now}";
            return View("CacheView");
        }

        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, Duration = duration)]
        public ActionResult Servers()
        {
            ViewBag.Message = $"Server:{DateTime.Now}";
            return View("CacheView");
        }

        [OutputCache(Location = System.Web.UI.OutputCacheLocation.ServerAndClient, Duration = duration)]
        public ActionResult ServerAndClient()
        {
            ViewBag.Message = $"ServerAndClient:{DateTime.Now}";
            return View("CacheView");
        }
    }
}