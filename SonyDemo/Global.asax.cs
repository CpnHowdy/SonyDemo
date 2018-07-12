using SonyDemo.Models;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SonyDemo
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // Registration for domain-level objects
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Test database connection
            using (var db = new SonyDbContext())
            {
                db.Games.Add(new Game
                {
                    Name = "Test Game 1"
                });
                db.SaveChanges();
            }
        }
    }
}
