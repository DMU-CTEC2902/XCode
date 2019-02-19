using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmReview.Startup))]
namespace FilmReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
