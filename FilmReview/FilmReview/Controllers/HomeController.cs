using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using FilmReview.Models;

namespace FilmReview.Controllers
{
    public class HomeController : Controller
    {
        private NewsContext db = new NewsContext();

        public ActionResult Index()
        {
            return View(db.News.ToList());
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