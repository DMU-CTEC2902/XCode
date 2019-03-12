﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmReview.Models
{
    public class NewsDataInitialiser : DropCreateDatabaseAlways<NewsContext>
    {
        protected override void Seed(NewsContext context)
        {
            News news1 = new News();
            news1.NewsID = 1;
            news1.Title = "Bohemian Rhapsody Sequel Being Discussed";
            news1.Subtitle = "Queen's music video director Rudi Dolezal says a sequel to hit film Bohemian Rhapsody is 'being heavily discussed'.";
            news1.Story = "Ut rutrum convallis ante, sed condimentum quam hendrerit sed. Vivamus libero velit, volutpat sit amet lobortis sed, sollicitudin id turpis. Nam sapien lacus, euismod quis sem ut, euismod molestie augue. Integer tincidunt commodo dolor. Curabitur lorem dolor, molestie a porta sed, efficitur ut velit. Suspendisse ut augue luctus, dignissim sem eget, pellentesque nibh. Donec maximus quam vehicula, auctor felis ut, rutrum nisl. Suspendisse ullamcorper nibh vel luctus hendrerit. In vulputate leo vel lobortis facilisis. Sed placerat tristique condimentum. Integer vitae justo velit. Mauris vulputate dui nulla. Praesent iaculis urna porttitor faucibus vehicula.Mauris euismod consequat tristique. Nunc ipsum arcu, dapibus eget nunc eu, bibendum pulvinar nibh. Vestibulum scelerisque ut velit consectetur interdum. Ut in tellus sagittis, gravida tellus ut, laoreet felis.Pellentesque auctor odio a neque consectetur eleifend.Donec sagittis turpis et arcu accumsan, vel imperdiet felis ullamcorper.Aliquam semper viverra tellus, et consectetur elit porta vitae. Quisque pellentesque tortor diam, quis luctus ligula dapibus sit amet.Sed ex risus, consectetur ut tristique nec, vehicula vitae nibh. Pellentesque gravida velit nec eros ullamcorper semper.Etiam mattis elit at facilisis cursus.In dui elit, sodales a lacinia vitae, bibendum ac ipsum. Donec turpis nisi, faucibus nec dui vel, rutrum aliquet urna. Vivamus sapien purus, pharetra quis elit vitae, pharetra ornare justo. Suspendisse potenti. Donec sit amet ante eget purus egestas consequat. Duis tincidunt tortor et porttitor sollicitudin. Ut viverra eu sem id mattis. Curabitur nec nibh facilisis, egestas erat ac, consequat sapien.Sed faucibus est id augue facilisis, a finibus mauris hendrerit.Sed iaculis commodo condimentum. Suspendisse vel molestie magna, ut vestibulum nibh. Aliquam erat volutpat.Nulla quis felis vel est eleifend ornare.Integer id sapien a lectus feugiat blandit mattis et neque. Vivamus ut tortor vel massa mattis rhoncus a nec nulla. Morbi odio est, hendrerit eleifend pretium viverra, rhoncus sit amet ex.Proin mollis hendrerit odio sed egestas. Fusce eget consectetur lectus. Pellentesque sit amet purus ut quam ornare rutrum pretium ut quam.Phasellus ullamcorper consequat diam, tristique posuere quam convallis non. Nulla sed vestibulum orci. Nam gravida, lectus quis posuere laoreet, ante massa fermentum felis, in dignissim enim neque ut dui.Phasellus a dui dignissim, porta mi non, sodales tellus.In et magna vitae justo tristique dapibus.Mauris eleifend, eros vel iaculis aliquam, elit ex hendrerit risus, sed finibus sapien turpis vel dolor.Nullam sit amet cursus tortor, eu vestibulum felis.Integer lacinia magna in mi luctus tempor.Integer egestas lacus eu consequat consectetur. Cras sit amet consectetur arcu.";
            news1.Date = Convert.ToDateTime("1/1/2019");
            context.News.Add(news1);

            News news2 = new News();
            news2.NewsID = 2;
            news2.Title = "Clark Gregg Slams Captain Marvel Trolls, Defends Brie Larson";
            news2.Subtitle = "Beloved Agents of SHIELD Clark Gregg is speaking out against the internet trolls who have been bombarding Captain Marvel and its star Brie Larson with hate since before the film's release.";
            news2.Story = "Condimentum quam hendrerit sed. Vivamus libero velit, volutpat sit amet lobortis sed, sollicitudin id turpis. Nam sapien lacus, euismod quis sem ut, euismod molestie augue. Integer tincidunt commodo dolor. Curabitur lorem dolor, molestie a porta sed, efficitur ut velit. Suspendisse ut augue luctus, dignissim sem eget, pellentesque nibh. Donec maximus quam vehicula, auctor felis ut, rutrum nisl. Suspendisse ullamcorper nibh vel luctus hendrerit. In vulputate leo vel lobortis facilisis. Sed placerat tristique condimentum. Integer vitae justo velit. Mauris vulputate dui nulla. Praesent iaculis urna porttitor faucibus vehicula.Mauris euismod consequat tristique. Nunc ipsum arcu, dapibus eget nunc eu, bibendum pulvinar nibh. Vestibulum scelerisque ut velit consectetur interdum. Ut in tellus sagittis, gravida tellus ut, laoreet felis.Pellentesque auctor odio a neque consectetur eleifend.Donec sagittis turpis et arcu accumsan, vel imperdiet felis ullamcorper.Aliquam semper viverra tellus, et consectetur elit porta vitae. Quisque pellentesque tortor diam, quis luctus ligula dapibus sit amet.Sed ex risus, consectetur ut tristique nec, vehicula vitae nibh. Pellentesque gravida velit nec eros ullamcorper semper.Etiam mattis elit at facilisis cursus.In dui elit, sodales a lacinia vitae, bibendum ac ipsum. Donec turpis nisi, faucibus nec dui vel, rutrum aliquet urna. Vivamus sapien purus, pharetra quis elit vitae, pharetra ornare justo. Suspendisse potenti. Donec sit amet ante eget purus egestas consequat. Duis tincidunt tortor et porttitor sollicitudin. Ut viverra eu sem id mattis. Curabitur nec nibh facilisis, egestas erat ac, consequat sapien.Sed faucibus est id augue facilisis, a finibus mauris hendrerit.Sed iaculis commodo condimentum. Suspendisse vel molestie magna, ut vestibulum nibh. Aliquam erat volutpat.Nulla quis felis vel est eleifend ornare.Integer id sapien a lectus feugiat blandit mattis et neque. Vivamus ut tortor vel massa mattis rhoncus a nec nulla. Morbi odio est, hendrerit eleifend pretium viverra, rhoncus sit amet ex.Proin mollis hendrerit odio sed egestas. Fusce eget consectetur lectus. Pellentesque sit amet purus ut quam ornare rutrum pretium ut quam.Phasellus ullamcorper consequat diam, tristique posuere quam convallis non. Nulla sed vestibulum orci. Nam gravida, lectus quis posuere laoreet, ante massa fermentum felis, in dignissim enim neque ut dui.Phasellus a dui dignissim, porta mi non, sodales tellus.In et magna vitae justo tristique dapibus.Mauris eleifend, eros vel iaculis aliquam, elit ex hendrerit risus, sed finibus sapien turpis vel dolor.Nullam sit amet cursus tortor, eu vestibulum felis.Integer lacinia magna in mi luctus tempor.Integer egestas lacus eu consequat consectetur. Cras sit amet consectetur arcu.";
            news2.Date = Convert.ToDateTime("1/1/2019");
            context.News.Add(news2);

            News news3 = new News();
            news3.NewsID = 3;
            news3.Title = "Ben Affleck is Still Open to Directing a DC Film";
            news3.Subtitle = "Ben Affleck says he would still be open to directing a DC movie if the right opportunity presented itself. The Oscar winner was originally set to helm a standalone Batman feature that he would also write and star in, but things obviously greatly changed since the time of that announcement.";
            news3.Story = "Vivamus libero velit, volutpat sit amet lobortis sed, sollicitudin id turpis. Nam sapien lacus, euismod quis sem ut, euismod molestie augue. Integer tincidunt commodo dolor. Curabitur lorem dolor, molestie a porta sed, efficitur ut velit. Suspendisse ut augue luctus, dignissim sem eget, pellentesque nibh. Donec maximus quam vehicula, auctor felis ut, rutrum nisl. Suspendisse ullamcorper nibh vel luctus hendrerit. In vulputate leo vel lobortis facilisis. Sed placerat tristique condimentum. Integer vitae justo velit. Mauris vulputate dui nulla. Praesent iaculis urna porttitor faucibus vehicula.Mauris euismod consequat tristique. Nunc ipsum arcu, dapibus eget nunc eu, bibendum pulvinar nibh. Vestibulum scelerisque ut velit consectetur interdum. Ut in tellus sagittis, gravida tellus ut, laoreet felis.Pellentesque auctor odio a neque consectetur eleifend.Donec sagittis turpis et arcu accumsan, vel imperdiet felis ullamcorper.Aliquam semper viverra tellus, et consectetur elit porta vitae. Quisque pellentesque tortor diam, quis luctus ligula dapibus sit amet.Sed ex risus, consectetur ut tristique nec, vehicula vitae nibh. Pellentesque gravida velit nec eros ullamcorper semper.Etiam mattis elit at facilisis cursus.In dui elit, sodales a lacinia vitae, bibendum ac ipsum. Donec turpis nisi, faucibus nec dui vel, rutrum aliquet urna. Vivamus sapien purus, pharetra quis elit vitae, pharetra ornare justo. Suspendisse potenti. Donec sit amet ante eget purus egestas consequat. Duis tincidunt tortor et porttitor sollicitudin. Ut viverra eu sem id mattis. Curabitur nec nibh facilisis, egestas erat ac, consequat sapien.Sed faucibus est id augue facilisis, a finibus mauris hendrerit.Sed iaculis commodo condimentum. Suspendisse vel molestie magna, ut vestibulum nibh. Aliquam erat volutpat.Nulla quis felis vel est eleifend ornare.Integer id sapien a lectus feugiat blandit mattis et neque. Vivamus ut tortor vel massa mattis rhoncus a nec nulla. Morbi odio est, hendrerit eleifend pretium viverra, rhoncus sit amet ex.Proin mollis hendrerit odio sed egestas. Fusce eget consectetur lectus. Pellentesque sit amet purus ut quam ornare rutrum pretium ut quam.Phasellus ullamcorper consequat diam, tristique posuere quam convallis non. Nulla sed vestibulum orci. Nam gravida, lectus quis posuere laoreet, ante massa fermentum felis, in dignissim enim neque ut dui.Phasellus a dui dignissim, porta mi non, sodales tellus.In et magna vitae justo tristique dapibus.Mauris eleifend, eros vel iaculis aliquam, elit ex hendrerit risus, sed finibus sapien turpis vel dolor.Nullam sit amet cursus tortor, eu vestibulum felis.Integer lacinia magna in mi luctus tempor.Integer egestas lacus eu consequat consectetur. Cras sit amet consectetur arcu.";
            news3.Date = Convert.ToDateTime("1/1/2019");
            context.News.Add(news3);

            News news4 = new News();
            news4.NewsID = 4;
            news4.Title = "The Hitman’s Bodyguard Sequel Casts Frank Grillo";
            news4.Subtitle = "Frank Grillo has been cast in The Hitman’s Wife’s Bodyguard, a sequel to The Hitman’s Bodyguard. In the Marvel Cinematic Universe, Grillo portrays Brock Rumlow aka Crossbones, the supervillain nemesis of Captain America.";
            news4.Story = "Amet lobortis sed, sollicitudin id turpis. Nam sapien lacus, euismod quis sem ut, euismod molestie augue. Integer tincidunt commodo dolor. Curabitur lorem dolor, molestie a porta sed, efficitur ut velit. Suspendisse ut augue luctus, dignissim sem eget, pellentesque nibh. Donec maximus quam vehicula, auctor felis ut, rutrum nisl. Suspendisse ullamcorper nibh vel luctus hendrerit. In vulputate leo vel lobortis facilisis. Sed placerat tristique condimentum. Integer vitae justo velit. Mauris vulputate dui nulla. Praesent iaculis urna porttitor faucibus vehicula.Mauris euismod consequat tristique. Nunc ipsum arcu, dapibus eget nunc eu, bibendum pulvinar nibh. Vestibulum scelerisque ut velit consectetur interdum. Ut in tellus sagittis, gravida tellus ut, laoreet felis.Pellentesque auctor odio a neque consectetur eleifend.Donec sagittis turpis et arcu accumsan, vel imperdiet felis ullamcorper.Aliquam semper viverra tellus, et consectetur elit porta vitae. Quisque pellentesque tortor diam, quis luctus ligula dapibus sit amet.Sed ex risus, consectetur ut tristique nec, vehicula vitae nibh. Pellentesque gravida velit nec eros ullamcorper semper.Etiam mattis elit at facilisis cursus.In dui elit, sodales a lacinia vitae, bibendum ac ipsum. Donec turpis nisi, faucibus nec dui vel, rutrum aliquet urna. Vivamus sapien purus, pharetra quis elit vitae, pharetra ornare justo. Suspendisse potenti. Donec sit amet ante eget purus egestas consequat. Duis tincidunt tortor et porttitor sollicitudin. Ut viverra eu sem id mattis. Curabitur nec nibh facilisis, egestas erat ac, consequat sapien.Sed faucibus est id augue facilisis, a finibus mauris hendrerit.Sed iaculis commodo condimentum. Suspendisse vel molestie magna, ut vestibulum nibh. Aliquam erat volutpat.Nulla quis felis vel est eleifend ornare.Integer id sapien a lectus feugiat blandit mattis et neque. Vivamus ut tortor vel massa mattis rhoncus a nec nulla. Morbi odio est, hendrerit eleifend pretium viverra, rhoncus sit amet ex.Proin mollis hendrerit odio sed egestas. Fusce eget consectetur lectus. Pellentesque sit amet purus ut quam ornare rutrum pretium ut quam.Phasellus ullamcorper consequat diam, tristique posuere quam convallis non. Nulla sed vestibulum orci. Nam gravida, lectus quis posuere laoreet, ante massa fermentum felis, in dignissim enim neque ut dui.Phasellus a dui dignissim, porta mi non, sodales tellus.In et magna vitae justo tristique dapibus.Mauris eleifend, eros vel iaculis aliquam, elit ex hendrerit risus, sed finibus sapien turpis vel dolor.Nullam sit amet cursus tortor, eu vestibulum felis.Integer lacinia magna in mi luctus tempor.Integer egestas lacus eu consequat consectetur. Cras sit amet consectetur arcu.";
            news4.Date = Convert.ToDateTime("1/1/2018");
            context.News.Add(news4);

            base.Seed(context);
        }
    }
}