using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace PaginaWS
{
    public class Global_asax : HttpApplication
    {
        public void Application_Start(object sender, EventArgs e)
        {
            // Se desencadena al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}