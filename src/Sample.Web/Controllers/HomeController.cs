using System.Web.Mvc;
using Sample.Web.Data;

namespace Sample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public string Index()
        {
            return "Index";
        }
    }
}
