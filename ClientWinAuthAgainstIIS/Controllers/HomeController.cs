namespace ClientWinAuthAgainstIIS.Controllers
{
    using System.Web.Http;

    public class HomeController : ApiController
    {
        public string Get()
        {
            return "Hello world";
        }
    }
}
