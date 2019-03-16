using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmReview.Models
{
    public class FilmInitialiser : DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {
            // Genres
            Genre Gen1 = new Genre();
            Gen1.GenreId = 1;
            Gen1.Name = "Action";
            Gen1.Description = "Action oriented movie";
            context.Genres.Add(Gen1);

            Genre Gen2 = new Genre();
            Gen2.GenreId = 2;
            Gen2.Name = "Horror";
            Gen2.Description = "Scary movies";
            context.Genres.Add(Gen2);

            Genre Gen3 = new Genre();
            Gen3.GenreId = 3;
            Gen3.Name = "Romance";
            Gen3.Description = "Romantic movies";
            context.Genres.Add(Gen3);

            Genre Gen4 = new Genre();
            Gen4.GenreId = 4;
            Gen4.Name = "Sci-fi";
            Gen4.Description = "Space oriented and adnvanced science";
            context.Genres.Add(Gen4);

            Genre Gen5 = new Genre();
            Gen5.GenreId = 5;
            Gen5.Name = "Fantasy";
            Gen5.Description = "Magical and exotic fantasy worlds";
            context.Genres.Add(Gen5);

            // Films
            Film film1 = new Film();
            film1.FilmId = 1;
            film1.GenreId = 1;
            film1.FilmName = "Bad Boys II";
            film1.Rating = 4.67M;
            film1.Description = "Narcotics cops Mike Lowrey (Will Smith) and Marcus Burnett (Martin Lawrence) head up a task force investigating the flow of ecstasy into Miami. Their search leads to a dangerous kingpin Johnny Tapia (Jordi Mollà), whose plan to control the city's drug traffic has touched off an underground war. Meanwhile, things get sexy between Mike and Syd (Gabrielle Union), Marcus's sister.";
            film1.Genre = Gen1;
            context.Films.Add(film1);

            Film film2 = new Film();
            film2.FilmId = 2;
            film2.GenreId = 1;
            film2.FilmName = "Bad Boys";
            film2.Rating = 8.00M;
            film2.Description = "A good movie!";
            film2.Genre = Gen1;
            context.Films.Add(film2);

            // Reviews
            Review review1 = new Review();
            review1.ReviewId = 1;
            review1.FilmId = 1;
            // Month/Day/Year | Hour/Minute/Second (24-hour clock)
            review1.DateAdded = Convert.ToDateTime("3/12/2019 09:02:12");
            review1.ReviewRating = 5;
            review1.Description = "Agree, pretty good.";
            context.Reviews.Add(review1);

            Review review2 = new Review();
            review2.ReviewId = 2;
            review2.FilmId = 1;
            // Month/Day/Year | Hour/Minute/Second (24-hour clock)
            review2.DateAdded = Convert.ToDateTime("3/13/2019 17:02:12");
            review2.ReviewRating = 4;
            review2.Description = "Bad.";
            context.Reviews.Add(review2);

            Review review3 = new Review();
            review3.ReviewId = 3;
            review3.FilmId = 1;
            // Month/Day/Year | Hour/Minute/Second (24-hour clock)
            review3.DateAdded = Convert.ToDateTime("3/13/2019 17:02:12");
            review3.ReviewRating = 5;
            review3.Description = "Bads.";
            context.Reviews.Add(review3);

            Review review4 = new Review();
            review4.ReviewId = 4;
            review4.FilmId = 2;
            // Month/Day/Year | Hour/Minute/Second (24-hour clock)
            review4.DateAdded = Convert.ToDateTime("3/13/2009 17:02:12");
            review4.ReviewRating = 8;
            review4.Description = "Fine.";
            context.Reviews.Add(review4);

            Review review5 = new Review();
            review5.ReviewId = 4;
            review5.FilmId = 2;
            // Month/Day/Year | Hour/Minute/Second (24-hour clock)
            review5.DateAdded = Convert.ToDateTime("3/13/2009 17:02:12");
            review5.ReviewRating = 9;
            review5.Description = "Fines.";
            context.Reviews.Add(review5);

            Review review6 = new Review();
            review6.ReviewId = 5;
            review6.FilmId = 2;
            // Month/Day/Year | Hour/Minute/Second (24-hour clock)
            review6.DateAdded = Convert.ToDateTime("3/13/2009 17:02:12");
            review6.ReviewRating = 10;
            review6.Description = "Fines.";
            context.Reviews.Add(review6);

            Review review7 = new Review();
            review7.ReviewId = 6;
            review7.FilmId = 2;
            // Month/Day/Year | Hour/Minute/Second (24-hour clock)
            review7.DateAdded = Convert.ToDateTime("3/13/2009 17:02:12");
            review7.ReviewRating = 5;
            review7.Description = "Fines.";
            context.Reviews.Add(review7);

            // Seed
            base.Seed(context);
        }
    }
}