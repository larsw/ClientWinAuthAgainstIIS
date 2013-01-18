namespace ClientWinAuthAgainstIIS
{
    using System.Web.Http;
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

            config.Formatters.Clear();
            config.Formatters.Add(new WebApiContrib.Formatting.PlainTextFormatter());
        }
    }
}
