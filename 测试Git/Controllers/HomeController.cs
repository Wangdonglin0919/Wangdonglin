using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 测试Git.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //123
            //裂哥好大儿
            //张子硕
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