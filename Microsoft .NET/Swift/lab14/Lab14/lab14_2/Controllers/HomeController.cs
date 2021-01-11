using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab14_2.Models;

namespace lab14_2.Controllers
{
    public class HomeController : Controller
    {
        myContex db = new myContex();
        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Film> films = db.Films;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Films = films;
            // возвращаем представление
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