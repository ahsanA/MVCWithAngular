using AngularTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularTest.Controllers
{
    public class HomeController : Controller
    {

        private ProjectDB db = new ProjectDB();
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

        public ActionResult Test()
        {
            return View();
        }

        public JsonResult GetAllStudent()
        {
            var students = db.Students.ToList();
            return Json(students,JsonRequestBehavior.AllowGet);
        }
    }
}