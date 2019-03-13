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
            return View(db.Films.OrderByDescending(x => x.Rating).ToList());
        }
    }
}