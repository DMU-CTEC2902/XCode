using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmReview.Models
{
    public class FilmInitialiser: DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {
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
            //hello?
            Film film1 = new Film();
            film1.FilmId = 1;
            film1.GenreId = 1;
            film1.FilmName = "Bad boys 2";
            film1.Rating = 9;
            film1.Description = "A very good movie!";
            film1.Genre = Gen1;
            context.Films.Add(film1);
            //ssdfsdfdsf
        
            base.Seed(context);

        }
    }
}