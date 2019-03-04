using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmReview.Models;

namespace FilmReview.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Random()
        {
            var news = new News() { Title = "TestNews" };

            return View(news);
        }
    }
}