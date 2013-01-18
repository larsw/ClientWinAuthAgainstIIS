using System.Web.Http;

namespace ClientWinAuthAgainstIIS.Controllers
{
    public class HomeController : ApiController
    {
        public string Get()
        {
            return "Hello world";
        }
    }
}
