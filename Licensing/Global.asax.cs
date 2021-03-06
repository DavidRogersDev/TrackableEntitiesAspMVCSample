﻿using Licensing.Core;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Licensing
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //ModelBinders.Binders.DefaultBinder = new BetterDefaultModelBinder();
            ModelBinders.Binders.Add(typeof(BetterDefaultModelBinder), new BetterDefaultModelBinder());
        }
    }
}
