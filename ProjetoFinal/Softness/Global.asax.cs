using Softness.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Softness
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object FilterConfig { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
