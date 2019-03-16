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
    public class FilmsController : Controller
    {
        private FilmContext db = new FilmContext();

        // GET: Films
        public ActionResult Index()
        {
            var films = db.Films.Include(f => f.Genre);
            return View(films.ToList());
        }

        // GET: Films/Title
        public ActionResult Title(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            List<Review> lstReviews = db.Reviews
                .Where(r => r.FilmId == id)
                .OrderByDescending(x => x.DateAdded).ToList();

            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Films/Title
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Title()
        {
            // Get the film id from a form
            int? id = Convert.ToInt32(Request.Form["FilmId"]);
            // If it doesn't exist
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Proceed only if there are no issues with the data posted
            if (ModelState.IsValid)
            {
                // New instance of Review class
                Review review = new Review();
                // Add the review description from a form
                review.Description = Request.Form["Review"];
                // Add the current date and time for a review
                review.DateAdded = DateTime.Now;
                // Add the film id that this review is related to
                review.FilmId = Convert.ToInt32(id);

                // Return any stars that was selected
                string temprating = Convert.ToString(Request.Form["rated"]);
                // Proceed only if there was a star selected
                if (temprating != ",,,,,,,,,")
                {
                    // Get the rating from the star that was selected
                    review.ReviewRating = Convert.ToDecimal(temprating.Split(',')[0]);
                    // Proceed only if there are no issues with the data posted
                    if (ModelState.IsValid)
                    {
                        // Find a film in the database
                        var FilmAfter = db.Films.Find(id);
                        // If it doesn't exist
                        if (FilmAfter == null)
                        {
                            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                        }

                        // Get the whole list of ratings for this movie
                        decimal[] AllReviews = db.Reviews.Where(r => r.FilmId == id).Select(x => x.ReviewRating).ToArray();
                        // Get the count of ratings for this movie
                        int ReviewCount = AllReviews.Length;
                        // Group them by rating and rating count
                        Dictionary<decimal, int> Ratings = AllReviews.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

                        // Weighted average calculation (includes the current rating)
                        decimal y = 0;
                        decimal p = review.ReviewRating;
                        foreach (var item in Ratings)
                        {
                            if (item.Key == review.ReviewRating)
                            {
                                decimal temporary = item.Value + 1;
                                decimal x = (item.Key) * temporary;
                                p = x;
                            }
                            else
                            {
                                decimal x = (item.Key) * (item.Value);
                                y += x;
                            }
                        }

                        // Adding p and +1 means it includes the current rating
                        FilmAfter.Rating = (y + p) / (ReviewCount + 1);
                        // Add only the calculated rating into the film table
                        db.Entry(FilmAfter).CurrentValues.SetValues(FilmAfter);
                        // Save changes
                        db.SaveChanges();
                    }
                }
                // Add the review with the amount of stars given to a movie
                db.Reviews.Add(review);
                // Save changes
                db.SaveChanges();
                // Redirect to the film page to see the updates
                RedirectToAction("Title");
            }

            // Get the list of reviews for the movie and order it by date
            List<Review> lstReviews = db.Reviews
                .Where(r => r.FilmId == id)
                .OrderByDescending(x => x.DateAdded).ToList();

            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Films/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name");
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmId,GenreId,FilmName,Rating,Description")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", film.GenreId);
            return View(film);
        }

        // GET: Films/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", film.GenreId);
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmId,GenreId,FilmName,Rating,Description")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", film.GenreId);
            return View(film);
        }

        // GET: Films/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Films.Find(id);
            db.Films.Remove(film);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}