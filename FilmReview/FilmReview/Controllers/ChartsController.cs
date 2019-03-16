using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FilmReview.Models;

namespace FilmReview.Controllers
{
    public class ChartsController : Controller
    {
        private FilmContext db = new FilmContext();

        // GET: Charts
        public ActionResult Index()
        {
            // Group the films and order them by review count, then take the top 5
            var Data = db.Reviews.OrderByDescending(x => x.ReviewRating).GroupBy(z => z.FilmId).Select(s => new { Filmid = s.Key, ReviewCount = s.Count(q => q.ReviewRating != 0), }).Take(5).ToList();

            // New dictionary for storing films name and review count
            Dictionary<string, int> MostReviewed = new Dictionary<string, int>();

            // For each film in the top 5
            foreach (var film in Data)
            {
                // Find the film by the FilmId
                Film Film = db.Films.Find(film.Filmid);
                // Add the name and review count to the dictionary
                MostReviewed.Add(Film.FilmName, film.ReviewCount);
            }

            // Add the dictionary to viewdata
            ViewData["MostReviewed"] = MostReviewed;

            return View(db.Films.OrderByDescending(x => x.Rating).Take(5).ToList());
        }
    }
}