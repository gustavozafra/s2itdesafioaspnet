using S2IT.Desafio.Application.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace S2IT.Desafio.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutoMapperConfig.RegisterMappings();
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            //
            if (HttpContext.Current.User != null)
            {
                //
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    //
                    if (HttpContext.Current.User.Identity is FormsIdentity)
                    {
                        //
                        FormsIdentity identity = (FormsIdentity)HttpContext.Current.User.Identity;
                        FormsAuthenticationTicket ticket = identity.Ticket;
                        string[] roles = ticket.UserData.Split(',');
                        HttpContext.Current.User = new System.Security.Principal.GenericPrincipal(identity, roles);
                    }
                }
            }
        }
    }
}
