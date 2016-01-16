using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using lightning.Models;

namespace lightning
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Database.SetInitializer<SubjectTrackingDB>(new SubjectTrackingInitializer());
     //       Database.SetInitializer<SubjectTrackingDB>(new SubjectTrackingInitializerCSV());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           // RegisterCSVHelper();
        }

        //private static void RegisterCSVHelper()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
