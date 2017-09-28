using System.Web.Mvc;

namespace SSoft.PhoneBook.Web.Controllers
{
    public class HomeController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}