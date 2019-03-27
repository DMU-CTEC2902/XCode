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

            Film film3 = new Film();
            film3.FilmId = 3;
            film3.GenreId = 5;
            film3.FilmName = "Barbie in the Pink Shoes";
            film3.Rating = 1.50M;
            film3.Description = "A movie made for kids!";
            film3.Genre = Gen5;
            context.Films.Add(film3);

            // Reviews
            Review review1 = new Review();
            review1.ReviewId = 1;
            review1.FilmId = 1;
            // new DateTime(year, month, day, hour, minute, second); (24-hour clock)
            review1.DateAdded = new DateTime(2019, 03, 12, 09, 02, 12);
            review1.ReviewRating = 5;
            review1.Description = "Agree, pretty good.";
            context.Reviews.Add(review1);

            Review review2 = new Review();
            review2.ReviewId = 2;
            review2.FilmId = 1;
            // new DateTime(year, month, day, hour, minute, second); (24-hour clock)
            review2.DateAdded = new DateTime(2019, 03, 13, 17, 02, 12);
            review2.ReviewRating = 4;
            review2.Description = "Bad.";
            context.Reviews.Add(review2);

            Review review3 = new Review();
            review3.ReviewId = 3;
            review3.FilmId = 1;
            // new DateTime(year, month, day, hour, minute, second); (24-hour clock)
            review3.DateAdded = new DateTime(2019, 03, 13, 17, 02, 12);
            review3.ReviewRating = 5;
            review3.Description = "Bads.";
            context.Reviews.Add(review3);

            Review review4 = new Review();
            review4.ReviewId = 4;
            review4.FilmId = 2;
            // new DateTime(year, month, day, hour, minute, second); (24-hour clock)
            review4.DateAdded = new DateTime(2019, 03, 13, 17, 02, 12);
            review4.ReviewRating = 8;
            review4.Description = "Fine.";
            context.Reviews.Add(review4);

            Review review5 = new Review();
            review5.ReviewId = 5;
            review5.FilmId = 2;
            // new DateTime(year, month, day, hour, minute, second); (24-hour clock)
            review5.DateAdded = new DateTime(2019, 01, 13, 17, 02, 12);
            review5.ReviewRating = 9;
            review5.Description = "Meh.";
            context.Reviews.Add(review5);

            Review review6 = new Review();
            review6.ReviewId = 6;
            review6.FilmId = 2;
            // new DateTime(year, month, day, hour, minute, second); (24-hour clock)
            review6.DateAdded = new DateTime(2019, 02, 13, 17, 02, 12);
            review6.ReviewRating = 10;
            review6.Description = "Fineeeee.";
            context.Reviews.Add(review6);

            Review review7 = new Review();
            review7.ReviewId = 7;
            review7.FilmId = 2;
            // new DateTime(year, month, day, hour, minute, second); (24-hour clock)
            review7.DateAdded = new DateTime(2018, 03, 13, 17, 02, 12);
            review7.ReviewRating = 5;
            review7.Description = "Finessz.";
            context.Reviews.Add(review7);

            Review review8 = new Review();
            review8.ReviewId = 8;
            review8.FilmId = 3;
            // new DateTime(year, month, day, hour, minute, second); (24-hour clock)
            review8.DateAdded = new DateTime(2018, 03, 13, 17, 02, 12);
            review8.ReviewRating = 1;
            review8.Description = "Badz.";
            context.Reviews.Add(review8);

            Review review9 = new Review();
            review9.ReviewId = 9;
            review9.FilmId = 3;
            // new DateTime(year, month, day, hour, minute, second); (24-hour clock)
            review9.DateAdded = new DateTime(2019, 03, 13, 17, 02, 12);
            review9.ReviewRating = 2;
            review9.Description = "Expected better.";
            context.Reviews.Add(review9);

            // News
            News news1 = new News();
            news1.NewsID = 1;
            news1.Title = "Bohemian Rhapsody Sequel Being Discussed";
            news1.Subtitle = "Queen's music video director Rudi Dolezal says a sequel to hit film Bohemian Rhapsody is 'being heavily discussed'.";
            news1.Story = "Ut rutrum convallis ante, sed condimentum quam hendrerit sed. Vivamus libero velit, volutpat sit amet lobortis sed, sollicitudin id turpis. Nam sapien lacus, euismod quis sem ut, euismod molestie augue. Integer tincidunt commodo dolor. Curabitur lorem dolor, molestie a porta sed, efficitur ut velit. Suspendisse ut augue luctus, dignissim sem eget, pellentesque nibh. Donec maximus quam vehicula, auctor felis ut, rutrum nisl. Suspendisse ullamcorper nibh vel luctus hendrerit. In vulputate leo vel lobortis facilisis. Sed placerat tristique condimentum. Integer vitae justo velit. Mauris vulputate dui nulla. Praesent iaculis urna porttitor faucibus vehicula.Mauris euismod consequat tristique. Nunc ipsum arcu, dapibus eget nunc eu, bibendum pulvinar nibh. Vestibulum scelerisque ut velit consectetur interdum. Ut in tellus sagittis, gravida tellus ut, laoreet felis.Pellentesque auctor odio a neque consectetur eleifend.Donec sagittis turpis et arcu accumsan, vel imperdiet felis ullamcorper.Aliquam semper viverra tellus, et consectetur elit porta vitae. Quisque pellentesque tortor diam, quis luctus ligula dapibus sit amet.Sed ex risus, consectetur ut tristique nec, vehicula vitae nibh. Pellentesque gravida velit nec eros ullamcorper semper.Etiam mattis elit at facilisis cursus.In dui elit, sodales a lacinia vitae, bibendum ac ipsum. Donec turpis nisi, faucibus nec dui vel, rutrum aliquet urna. Vivamus sapien purus, pharetra quis elit vitae, pharetra ornare justo. Suspendisse potenti. Donec sit amet ante eget purus egestas consequat. Duis tincidunt tortor et porttitor sollicitudin. Ut viverra eu sem id mattis. Curabitur nec nibh facilisis, egestas erat ac, consequat sapien.Sed faucibus est id augue facilisis, a finibus mauris hendrerit.Sed iaculis commodo condimentum. Suspendisse vel molestie magna, ut vestibulum nibh. Aliquam erat volutpat.Nulla quis felis vel est eleifend ornare.Integer id sapien a lectus feugiat blandit mattis et neque. Vivamus ut tortor vel massa mattis rhoncus a nec nulla. Morbi odio est, hendrerit eleifend pretium viverra, rhoncus sit amet ex.Proin mollis hendrerit odio sed egestas. Fusce eget consectetur lectus. Pellentesque sit amet purus ut quam ornare rutrum pretium ut quam.Phasellus ullamcorper consequat diam, tristique posuere quam convallis non. Nulla sed vestibulum orci. Nam gravida, lectus quis posuere laoreet, ante massa fermentum felis, in dignissim enim neque ut dui.Phasellus a dui dignissim, porta mi non, sodales tellus.In et magna vitae justo tristique dapibus.Mauris eleifend, eros vel iaculis aliquam, elit ex hendrerit risus, sed finibus sapien turpis vel dolor.Nullam sit amet cursus tortor, eu vestibulum felis.Integer lacinia magna in mi luctus tempor.Integer egestas lacus eu consequat consectetur. Cras sit amet consectetur arcu.";
            // new DateTime(year, month, day);
            news1.Date = new DateTime(2019, 03, 12);
            context.News.Add(news1);

            News news2 = new News();
            news2.NewsID = 2;
            news2.Title = "Clark Gregg Slams Captain Marvel Trolls, Defends Brie Larson";
            news2.Subtitle = "Beloved Agents of SHIELD Clark Gregg is speaking out against the internet trolls who have been bombarding Captain Marvel and its star Brie Larson with hate since before the film's release.";
            news2.Story = "Condimentum quam hendrerit sed. Vivamus libero velit, volutpat sit amet lobortis sed, sollicitudin id turpis. Nam sapien lacus, euismod quis sem ut, euismod molestie augue. Integer tincidunt commodo dolor. Curabitur lorem dolor, molestie a porta sed, efficitur ut velit. Suspendisse ut augue luctus, dignissim sem eget, pellentesque nibh. Donec maximus quam vehicula, auctor felis ut, rutrum nisl. Suspendisse ullamcorper nibh vel luctus hendrerit. In vulputate leo vel lobortis facilisis. Sed placerat tristique condimentum. Integer vitae justo velit. Mauris vulputate dui nulla. Praesent iaculis urna porttitor faucibus vehicula.Mauris euismod consequat tristique. Nunc ipsum arcu, dapibus eget nunc eu, bibendum pulvinar nibh. Vestibulum scelerisque ut velit consectetur interdum. Ut in tellus sagittis, gravida tellus ut, laoreet felis.Pellentesque auctor odio a neque consectetur eleifend.Donec sagittis turpis et arcu accumsan, vel imperdiet felis ullamcorper.Aliquam semper viverra tellus, et consectetur elit porta vitae. Quisque pellentesque tortor diam, quis luctus ligula dapibus sit amet.Sed ex risus, consectetur ut tristique nec, vehicula vitae nibh. Pellentesque gravida velit nec eros ullamcorper semper.Etiam mattis elit at facilisis cursus.In dui elit, sodales a lacinia vitae, bibendum ac ipsum. Donec turpis nisi, faucibus nec dui vel, rutrum aliquet urna. Vivamus sapien purus, pharetra quis elit vitae, pharetra ornare justo. Suspendisse potenti. Donec sit amet ante eget purus egestas consequat. Duis tincidunt tortor et porttitor sollicitudin. Ut viverra eu sem id mattis. Curabitur nec nibh facilisis, egestas erat ac, consequat sapien.Sed faucibus est id augue facilisis, a finibus mauris hendrerit.Sed iaculis commodo condimentum. Suspendisse vel molestie magna, ut vestibulum nibh. Aliquam erat volutpat.Nulla quis felis vel est eleifend ornare.Integer id sapien a lectus feugiat blandit mattis et neque. Vivamus ut tortor vel massa mattis rhoncus a nec nulla. Morbi odio est, hendrerit eleifend pretium viverra, rhoncus sit amet ex.Proin mollis hendrerit odio sed egestas. Fusce eget consectetur lectus. Pellentesque sit amet purus ut quam ornare rutrum pretium ut quam.Phasellus ullamcorper consequat diam, tristique posuere quam convallis non. Nulla sed vestibulum orci. Nam gravida, lectus quis posuere laoreet, ante massa fermentum felis, in dignissim enim neque ut dui.Phasellus a dui dignissim, porta mi non, sodales tellus.In et magna vitae justo tristique dapibus.Mauris eleifend, eros vel iaculis aliquam, elit ex hendrerit risus, sed finibus sapien turpis vel dolor.Nullam sit amet cursus tortor, eu vestibulum felis.Integer lacinia magna in mi luctus tempor.Integer egestas lacus eu consequat consectetur. Cras sit amet consectetur arcu.";
            // new DateTime(year, month, day);
            news2.Date = new DateTime(2019, 03, 11);
            context.News.Add(news2);

            News news3 = new News();
            news3.NewsID = 3;
            news3.Title = "Ben Affleck is Still Open to Directing a DC Film";
            news3.Subtitle = "Ben Affleck says he would still be open to directing a DC movie if the right opportunity presented itself. The Oscar winner was originally set to helm a standalone Batman feature that he would also write and star in, but things obviously greatly changed since the time of that announcement.";
            news3.Story = "Vivamus libero velit, volutpat sit amet lobortis sed, sollicitudin id turpis. Nam sapien lacus, euismod quis sem ut, euismod molestie augue. Integer tincidunt commodo dolor. Curabitur lorem dolor, molestie a porta sed, efficitur ut velit. Suspendisse ut augue luctus, dignissim sem eget, pellentesque nibh. Donec maximus quam vehicula, auctor felis ut, rutrum nisl. Suspendisse ullamcorper nibh vel luctus hendrerit. In vulputate leo vel lobortis facilisis. Sed placerat tristique condimentum. Integer vitae justo velit. Mauris vulputate dui nulla. Praesent iaculis urna porttitor faucibus vehicula.Mauris euismod consequat tristique. Nunc ipsum arcu, dapibus eget nunc eu, bibendum pulvinar nibh. Vestibulum scelerisque ut velit consectetur interdum. Ut in tellus sagittis, gravida tellus ut, laoreet felis.Pellentesque auctor odio a neque consectetur eleifend.Donec sagittis turpis et arcu accumsan, vel imperdiet felis ullamcorper.Aliquam semper viverra tellus, et consectetur elit porta vitae. Quisque pellentesque tortor diam, quis luctus ligula dapibus sit amet.Sed ex risus, consectetur ut tristique nec, vehicula vitae nibh. Pellentesque gravida velit nec eros ullamcorper semper.Etiam mattis elit at facilisis cursus.In dui elit, sodales a lacinia vitae, bibendum ac ipsum. Donec turpis nisi, faucibus nec dui vel, rutrum aliquet urna. Vivamus sapien purus, pharetra quis elit vitae, pharetra ornare justo. Suspendisse potenti. Donec sit amet ante eget purus egestas consequat. Duis tincidunt tortor et porttitor sollicitudin. Ut viverra eu sem id mattis. Curabitur nec nibh facilisis, egestas erat ac, consequat sapien.Sed faucibus est id augue facilisis, a finibus mauris hendrerit.Sed iaculis commodo condimentum. Suspendisse vel molestie magna, ut vestibulum nibh. Aliquam erat volutpat.Nulla quis felis vel est eleifend ornare.Integer id sapien a lectus feugiat blandit mattis et neque. Vivamus ut tortor vel massa mattis rhoncus a nec nulla. Morbi odio est, hendrerit eleifend pretium viverra, rhoncus sit amet ex.Proin mollis hendrerit odio sed egestas. Fusce eget consectetur lectus. Pellentesque sit amet purus ut quam ornare rutrum pretium ut quam.Phasellus ullamcorper consequat diam, tristique posuere quam convallis non. Nulla sed vestibulum orci. Nam gravida, lectus quis posuere laoreet, ante massa fermentum felis, in dignissim enim neque ut dui.Phasellus a dui dignissim, porta mi non, sodales tellus.In et magna vitae justo tristique dapibus.Mauris eleifend, eros vel iaculis aliquam, elit ex hendrerit risus, sed finibus sapien turpis vel dolor.Nullam sit amet cursus tortor, eu vestibulum felis.Integer lacinia magna in mi luctus tempor.Integer egestas lacus eu consequat consectetur. Cras sit amet consectetur arcu.";
            // new DateTime(year, month, day);
            news3.Date = new DateTime(2018, 09, 03);
            context.News.Add(news3);

            News news4 = new News();
            news4.NewsID = 4;
            news4.Title = "The Hitman’s Bodyguard Sequel Casts Frank Grillo";
            news4.Subtitle = "Frank Grillo has been cast in The Hitman’s Wife’s Bodyguard, a sequel to The Hitman’s Bodyguard. In the Marvel Cinematic Universe, Grillo portrays Brock Rumlow aka Crossbones, the supervillain nemesis of Captain America.";
            news4.Story = "Amet lobortis sed, sollicitudin id turpis. Nam sapien lacus, euismod quis sem ut, euismod molestie augue. Integer tincidunt commodo dolor. Curabitur lorem dolor, molestie a porta sed, efficitur ut velit. Suspendisse ut augue luctus, dignissim sem eget, pellentesque nibh. Donec maximus quam vehicula, auctor felis ut, rutrum nisl. Suspendisse ullamcorper nibh vel luctus hendrerit. In vulputate leo vel lobortis facilisis. Sed placerat tristique condimentum. Integer vitae justo velit. Mauris vulputate dui nulla. Praesent iaculis urna porttitor faucibus vehicula.Mauris euismod consequat tristique. Nunc ipsum arcu, dapibus eget nunc eu, bibendum pulvinar nibh. Vestibulum scelerisque ut velit consectetur interdum. Ut in tellus sagittis, gravida tellus ut, laoreet felis.Pellentesque auctor odio a neque consectetur eleifend.Donec sagittis turpis et arcu accumsan, vel imperdiet felis ullamcorper.Aliquam semper viverra tellus, et consectetur elit porta vitae. Quisque pellentesque tortor diam, quis luctus ligula dapibus sit amet.Sed ex risus, consectetur ut tristique nec, vehicula vitae nibh. Pellentesque gravida velit nec eros ullamcorper semper.Etiam mattis elit at facilisis cursus.In dui elit, sodales a lacinia vitae, bibendum ac ipsum. Donec turpis nisi, faucibus nec dui vel, rutrum aliquet urna. Vivamus sapien purus, pharetra quis elit vitae, pharetra ornare justo. Suspendisse potenti. Donec sit amet ante eget purus egestas consequat. Duis tincidunt tortor et porttitor sollicitudin. Ut viverra eu sem id mattis. Curabitur nec nibh facilisis, egestas erat ac, consequat sapien.Sed faucibus est id augue facilisis, a finibus mauris hendrerit.Sed iaculis commodo condimentum. Suspendisse vel molestie magna, ut vestibulum nibh. Aliquam erat volutpat.Nulla quis felis vel est eleifend ornare.Integer id sapien a lectus feugiat blandit mattis et neque. Vivamus ut tortor vel massa mattis rhoncus a nec nulla. Morbi odio est, hendrerit eleifend pretium viverra, rhoncus sit amet ex.Proin mollis hendrerit odio sed egestas. Fusce eget consectetur lectus. Pellentesque sit amet purus ut quam ornare rutrum pretium ut quam.Phasellus ullamcorper consequat diam, tristique posuere quam convallis non. Nulla sed vestibulum orci. Nam gravida, lectus quis posuere laoreet, ante massa fermentum felis, in dignissim enim neque ut dui.Phasellus a dui dignissim, porta mi non, sodales tellus.In et magna vitae justo tristique dapibus.Mauris eleifend, eros vel iaculis aliquam, elit ex hendrerit risus, sed finibus sapien turpis vel dolor.Nullam sit amet cursus tortor, eu vestibulum felis.Integer lacinia magna in mi luctus tempor.Integer egestas lacus eu consequat consectetur. Cras sit amet consectetur arcu.";
            // new DateTime(year, month, day);
            news4.Date = new DateTime(2019, 03, 10);
            context.News.Add(news4);

            // Actors
            Actor actor1 = new Actor();
            actor1.ActorID = 1;
            actor1.FilmId = 1;
            actor1.FirstName = "Will";
            actor1.LastName = "Smith";
            context.Actors.Add(actor1);

            Actor actor2 = new Actor();
            actor2.ActorID = 2;
            actor2.FilmId = 2;
            actor2.FirstName = "Martin";
            actor2.LastName = "Lawrence";
            context.Actors.Add(actor2);

            Actor actor3 = new Actor();
            actor3.ActorID = 3;
            actor3.FilmId = 3;
            actor3.FirstName = "Matthew";
            actor3.LastName = "Dean";
            context.Actors.Add(actor3);

            Actor actor4 = new Actor();
            actor4.ActorID = 4;
            actor4.FilmId = 1;
            actor4.FirstName = "Téa";
            actor4.LastName = "Leoni";
            context.Actors.Add(actor4);

            Actor actor5 = new Actor();
            actor5.ActorID = 5;
            actor5.FilmId = 1;
            actor5.FirstName = "Tchéky";
            actor5.LastName = "Karyo";
            context.Actors.Add(actor5);

            // Seed
            base.Seed(context);
        }
    }
}