using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using FilmReview.Models;

namespace FilmReview
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //aa
        protected void Application_Start()
        {
            Database.SetInitializer(new FilmInitialiser());
            Database.SetInitializer(new NewsDataInitialiser());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
