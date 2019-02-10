using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Swashbuckle.Application;

namespace webAPI.webAPI.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            LoggingConfig.Register();
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(name: "swagger_root",
            routeTemplate: "",
            defaults: null,
            constraints: null,
            handler: new RedirectHandler((message => message.RequestUri.ToString()), "swagger"));
            SwaggerConfig.Register(config);

            WebApiConfig.Register(config);
            app.UseNinjectMiddleware(NinjectConfig.CreateKernel)
               .UseNinjectWebApi(config);

            config.EnsureInitialized();
        }
    }

}