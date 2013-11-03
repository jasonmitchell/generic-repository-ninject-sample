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
            //var customers = from c in repository.Query<Customer>()
            //                where c.FirstName == "Jason"
            //                select c;

            return "Index";
        }
    }
}
