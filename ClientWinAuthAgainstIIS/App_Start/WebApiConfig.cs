using System.Web.Http;

namespace ClientWinAuthAgainstIIS
{
    using System.Web.Mvc;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { controller = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
