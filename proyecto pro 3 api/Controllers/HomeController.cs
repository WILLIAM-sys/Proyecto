using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto_pro_3_api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PanelEstudiante()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PanelDocente()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PanelAdmin()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult InvalidAccount()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}