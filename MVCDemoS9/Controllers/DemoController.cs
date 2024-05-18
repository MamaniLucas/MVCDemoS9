using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoS9.Controllers
{
    public class DemoController : Controller
    {
        // Función de tipo GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        // REtorna un HTML y por ello se debe asignar-una vista  
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}