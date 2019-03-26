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
        private FilmContext db = new FilmContext();

        public ActionResult Index()
        {
            // Order the films by the highest rating, take the top 3 and add them to the list
            List<Film> MostPopular = db.Films.OrderByDescending(x => x.Rating).Take(3).ToList();
            // Add the list to viewdata
            ViewData["MostPopular"] = MostPopular;

            return View(db.News.OrderByDescending(x => x.Date).ToList());
        }
    }
}